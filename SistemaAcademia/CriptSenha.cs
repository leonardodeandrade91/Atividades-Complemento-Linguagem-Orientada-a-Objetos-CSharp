using System;
using System.Security.Cryptography;
using System.Text;

namespace SistemaAcademia {
    class CriptSenha {
        public static string encripta(string valor, string tipo) {
            string hash;

            if(tipo.Equals("SHA-1")) {
                SHA1 dados = new SHA1CryptoServiceProvider();

                hash = BitConverter.ToString(dados.ComputeHash(Encoding.UTF8.GetBytes(valor))).Replace("-", string.Empty).ToLower();
            }
            else if(tipo.Equals("SHA-256")) {
                SHA256 dados = new SHA256CryptoServiceProvider();

                hash = BitConverter.ToString(dados.ComputeHash(Encoding.UTF8.GetBytes(valor))).Replace("-", string.Empty).ToLower();
            }
            else {
                MD5 dados = new MD5CryptoServiceProvider();

                hash = BitConverter.ToString(dados.ComputeHash(Encoding.UTF8.GetBytes(valor))).Replace("-", string.Empty).ToLower();
            }

            return hash;
        }
    }
}
