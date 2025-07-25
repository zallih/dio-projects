using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEntendendoC.Models {
    public class Cursos {

        public Cursos(string nome) {
            Nome = nome;
        }
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }


        public void AdicionarAluno(Pessoa aluno) {
            Alunos.Add(aluno);
            Console.WriteLine($"Aluno {aluno.NomeCompleto} adicionado ao curso {Nome}.");
        }

        public int ObterTotalAlunos() {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool ExcluirAluno(Pessoa aluno) {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos() {
            if (Alunos == null || Alunos.Count == 0) {
                Console.WriteLine("Nenhum aluno cadastrado.");
                return;
            }

            foreach (var aluno in Alunos) {
                Console.WriteLine($"Nome: {aluno.NomeCompleto}, Idade: {aluno.Idade}");
            }
        }
    }
}