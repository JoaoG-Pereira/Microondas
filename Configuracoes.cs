using Microondas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas
{
    public static class Configuracoes
    {
        public const string API_URL = "https://localhost:44321";
        public const string PROGRAMAS_URL = API_URL +"/api/programas";

        public static Usuario USUARIO_LOGADO = null;
    }
}
