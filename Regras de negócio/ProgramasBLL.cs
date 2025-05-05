using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Microondas
{
    public static class ProgramasBLL
    {
        public async static Task<Alimento> CriarPrograma(Alimento alimento)
        {
            var listaAlimentos = (await ListarProgramas()).ToList();
            if (listaAlimentos.Where(a => a.nome == alimento.nome).Count() > 0) throw new Exception($"O programa {alimento.nome} já existe!");

            if (listaAlimentos.Count > 0)
                alimento.id = listaAlimentos.Max(a => a.id) + 1;
            else
                alimento.id = 1;

            return await ProgramasDAL.CriarPrograma(alimento);
        }

        public static async Task<Alimento[]> ListarProgramas()
        {
            return await ProgramasDAL.ListarProgramas();
        }

        public async static Task<Alimento> EditarPrograma(Alimento alimento)
        {
            var alimentoSelecionado = (await ListarProgramas()).FirstOrDefault(a => a.id == alimento.id);

            if (alimentoSelecionado == null) throw new Exception();
            if (alimentoSelecionado.customizado) throw new Exception($"O programa { alimentoSelecionado.nome } não pode ser alterado!");

            return await ProgramasDAL.EditarPrograma(alimento);
        }

        public async static void DeletarPrograma(int id)
        {
            var alimentoSelecionado = (await ListarProgramas()).FirstOrDefault(a => a.id == id);

            if (alimentoSelecionado == null) throw new Exception();
            if (alimentoSelecionado.customizado) throw new Exception("O programa " + alimentoSelecionado.nome + " não pode ser alterado!");

            await ProgramasDAL.DeletarPrograma(id);
        }

        private static void Salvar(IEnumerable<Alimento> listaAlimentos)
        {
            string stringAlimentos = JsonSerializer.Serialize(listaAlimentos);
            File.WriteAllText("alimentos.json", stringAlimentos);
        }

    }
}
