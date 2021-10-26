using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper
    {
        //securitykeyi byte çeviryor ve simetrik halw getiriyor
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            //aspnet için kullanacağımız anahtar
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
 