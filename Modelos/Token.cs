using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas
{
    public class Token
    {
        private readonly string access_token;
        private readonly int expira_em; //Segundos
        private readonly DateTime data_emissao;

        public Token(string access_token, int expira_em, DateTime data_emissao)
        {
            this.access_token = access_token;
            this.data_emissao = data_emissao;
            this.expira_em = expira_em;
        }

        public bool EstaExpirado()
        {
            return (DateTime.Now - data_emissao).TotalSeconds >= expira_em;
        }
    }
}
