using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        //Güvenlik anahtarı ve algoritmasını burada belirityoruz
        //imzalama nesnesi yapacak
        //anahtar olarak bu security key kullan
        //algoritma olarak da hmc512 kullan 
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {            
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);

        }
    }
}
