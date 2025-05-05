using Microondas.Dados;
using Microondas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Microondas.Regras_de_negócio
{
    public class UsuariosBLL
    {
        public async static Task CriarUsuario(Usuario usuario)
        {
            Usuario novoUsuario = await UsuariosDAL.CriarUsuario(usuario);
            await FazerLogin(novoUsuario);
        }

        public async static Task FazerLogin(Usuario usuario)
        {
            if (!await UsuariosDAL.ValidarLogin(usuario))
                throw new Exception("A senha está incorreta");

            Configuracoes.USUARIO_LOGADO = usuario;
        }

        public bool UsuarioLogado()
        {
            return Configuracoes.USUARIO_LOGADO != null;
        }
    }
}
