using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //out keywordleri ile gönderilen 2 değeri doldurup geri döndürecek
        //verdiğimiz passwordü out ile hash ve salt olarak bize gönderecek
        //.net cyripto ile yapacağız
        //hmac:cyripto sınıfında kullandığımkız sınıfa karşılık geliyor
        //hmacsga512:saltda oluşturacak
        public static void CreatePasswordHash(string password,
            out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                //key olarak atadık,algoritmanın şiferler için yapısı
                //her kullanıcı için key oluşturur
                passwordSalt = hmac.Key;
                //parolayı hash değerine dönüştürecek
                //Encoding.UTF8.GeyBytes ile byte çevirme işlemi yapılır
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        // out olmama sebebi burda değerleri biz vereceğiz
        //haslemeyi kontrol ettiğimiz yer burası
        //burdaki parola sisteme giriş yaparkenki parola
        //PAROLANIN DOĞRU GİRİLİP GİRİLMEDİĞİNİ KONTROL ETTİĞİMİZ YER
        public static bool VerifyPasswordHash(string password,
             byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                //gönderilen paraloyı tek tek dolaş
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        //eğer eşleşmezse yanlış döndür
                        return false;
                    }
                }
            }
            return true;

        }
    }
}
