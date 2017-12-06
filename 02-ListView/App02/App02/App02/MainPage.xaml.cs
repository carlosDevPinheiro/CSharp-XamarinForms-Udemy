using System.Collections.Generic;

namespace App02
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            ListaFuncionarios.ItemsSource = GetFuncionario();
        }


        public List<Grupo> GetFuncionario()
        {
            return new List<Grupo>
            {
                new Grupo("Presidente","CEO","Presidente da America")
                {
                    new Pessoa() { Nome = "Jose", IsObrigatorio = true, RankEficiencia = 8}
                },
                new Grupo("Diretores","Dir.", "America do Sul")
                {
                    new Pessoa(){ Nome = "Maria", IsObrigatorio = true, RankEficiencia = 8},
                    new Pessoa(){ Nome = "João", IsObrigatorio = false}
                },
                new Grupo("Gerentes","Ger.", "Brasil")
                {
                    new Pessoa(){ Nome = "Felipe", IsObrigatorio = true, RankEficiencia = 8},
                    new Pessoa(){ Nome = "Judas", IsObrigatorio = false}
                },
                new Grupo("Funcionarios","Ope", "Funcionarios da empresa")
                {
                        new Pessoa { Nome = "Felipe - Funcionario",IsObrigatorio = false,},
                        new Pessoa { Nome = "Judas - Funcionario",IsObrigatorio = false, },
                        new Pessoa { Nome = "Jose - Funcionario",IsObrigatorio = false,  },
                        new Pessoa { Nome = "Maria - Funcionario",IsObrigatorio = false,},
                        new Pessoa { Nome = "João - Funcionario",IsObrigatorio = true, RankEficiencia = 6},
                        new Pessoa { Nome = "Felipe - Funcionario",IsObrigatorio = false},
                        new Pessoa { Nome = "Judas - Funcionario",IsObrigatorio = false},
                        new Pessoa { Nome = "Danilo - Funcionario",IsObrigatorio = false},
                        new Pessoa { Nome = "Helen - Funcionario",IsObrigatorio = false}
                }
            };
        }

        public class Grupo : List<Pessoa>
        {
            public Grupo(string titulo, string tituloCurto, string descricao)
            {
                Titulo = titulo;
                TituloCurto = tituloCurto;
                Descricao = descricao;
            }

            public string Titulo { get; set; }
            public string TituloCurto { get; set; }
            public string Descricao { get; set; }

        }
        public class Pessoa
        {
            public string Nome { get; set; }
            public int RankEficiencia { get; set; }
            public bool IsObrigatorio { get; set; }
        }
    }



}
