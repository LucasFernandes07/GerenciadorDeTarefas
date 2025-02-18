
using System.Diagnostics.Contracts;
using System.Dynamic;
using Layout;

namespace Tarefas
{
    class Tarefa    
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluido { get; set; }

        public Tarefa (int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            Concluido = false;
        }

        public void ExibirTarefa()
        {
            Formatacao.Cor($"[{(Concluido ? "X" : " ")}] ID: {Id} - {Descricao}",ConsoleColor.Yellow);
        }


    }
}