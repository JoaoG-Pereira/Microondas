using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.Modelos
{
    public class Usuario
    {
        public string nome;
        public string senha;

        public Usuario(string nome, string senha)
        {
            this.nome = nome;
            this.senha = CriptografarSenha(senha);
        }

        private string CriptografarSenha(string senha)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // Convert to hexadecimal representation
                }

                return builder.ToString();
            }
        }

    }
}
