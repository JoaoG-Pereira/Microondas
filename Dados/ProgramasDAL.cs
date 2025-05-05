using Microondas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Microondas
{
    public static class ProgramasDAL
    {
        private static readonly HttpClient client = new HttpClient();
        private static Token token;

        public async static Task<Alimento> CriarPrograma(Alimento alimento)
        {
            await ValidarToken();
            string jsonBody = JsonSerializer.Serialize(alimento);
            StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync($"{Configuracoes.PROGRAMAS_URL}/criar", content);
            string responseBody = await response.Content.ReadAsStringAsync();

            Alimento novoRegistro = JsonSerializer.Deserialize<Alimento>(responseBody);
            return novoRegistro;
        }

        public static async Task<Alimento[]> ListarProgramas()
        {
            await ValidarToken();
            HttpResponseMessage response = await client.GetAsync($"{Configuracoes.PROGRAMAS_URL}");
            string responseBody = await response.Content.ReadAsStringAsync();

            Alimento[] alimentos = JsonSerializer.Deserialize<Alimento[]>(responseBody);
            return alimentos;
        }

        public async static Task<Alimento> EditarPrograma(Alimento alimento)
        {
            await ValidarToken();
            string jsonBody = JsonSerializer.Serialize(alimento);
            StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync($"{Configuracoes.PROGRAMAS_URL}/editar", content);
            string responseBody = await response.Content.ReadAsStringAsync();

            Alimento novoRegistro = JsonSerializer.Deserialize<Alimento>(responseBody);
            return novoRegistro;
        }

        public async static Task DeletarPrograma(int id)
        {
            await ValidarToken();
            HttpResponseMessage response = await client.DeleteAsync($"{Configuracoes.PROGRAMAS_URL}/deletar/{id}");
            string responseBody = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) throw new Exception(responseBody);
        }

        public async static Task GerarToken(Usuario usuario)
        {
            HttpClient client = new HttpClient();
            var values = new Dictionary<string, string>
        {
            { "username", $"{usuario.nome}" },
            { "password", $"{usuario.senha}" },
            { "grant_type", $"password" }
        };

            var content = new FormUrlEncodedContent(values);

            HttpResponseMessage response = await client.PostAsync($"{Configuracoes.API_URL}/token", content);
            string responseBody = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) throw new Exception("Não foi possível gerar o token de acesso à API!");

            var jsonDoc = JsonDocument.Parse(responseBody);
            string access_token = jsonDoc.RootElement.GetProperty("access_token").ToString();
            var expires_in = jsonDoc.RootElement.GetProperty("expires_in").GetInt32();

            token = new Token(access_token, expires_in, DateTime.Now); //Salva o token
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);
        }

        private async static Task ValidarToken()
        {
            if (Configuracoes.USUARIO_LOGADO == null) throw new Exception();

            if (token == null || token.EstaExpirado())
                await GerarToken(new Usuario("admin", "1234"));
        }

    }
}
