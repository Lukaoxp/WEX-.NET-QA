namespace Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine("Professor");
        }
    }
}