using Microondas.Modelos;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microondas.Dados
{
    public class UsuariosDAL
    {
        private static readonly HttpClient client = new HttpClient();

        public async static Task<Usuario> CriarUsuario(Usuario usuario)
        {
            /*if (UsuarioExiste(usuario.nome)) throw new Exception($"O usuário { usuario.nome } já está registrado!");

            string jsonBody = JsonSerializer.Serialize(alimento);
            StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync($"{Configuracoes.PROGRAMAS_URL}/criar", content);
            string responseBody = await response.Content.ReadAsStringAsync();

            Usuario novoRegistro = JsonSerializer.Deserialize<Usuario>(responseBody);
            return novoRegistro;*/
            return new Usuario("", "");

        }

        public async static Task<bool> ValidarLogin(Usuario usuario)
        {
            try
            {
                await ProgramasDAL.GerarToken(usuario);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool UsuarioExiste(string nome)
        {
            return true;
        }

    }
}
