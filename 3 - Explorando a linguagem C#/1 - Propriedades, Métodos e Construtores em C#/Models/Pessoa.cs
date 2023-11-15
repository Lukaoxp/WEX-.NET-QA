namespace _1___Propriedades__Métodos_e_Construtores_em_C_.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = 1;
        }
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        private string _nome;
        private int _idade;
       
        public string Nome { 
            get => _nome;
            
            set{
                if(value == null || value == ""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade { 
            get => _idade;

            set{
                if (value < 0){
                    throw new ArgumentException("A idade não pode ser menor do que zero");
                }
                _idade = value;
            } 
        }
        
        public void Apresentar(){
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}