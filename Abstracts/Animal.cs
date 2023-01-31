using System;

namespace Animals
{
    public abstract class Animal
    {
        public string Nome;
        public DateTime DataNascimento { get; init; }
        public char Sexo { get; init; }

        public abstract bool Carnivoro { get; }
        public abstract bool Peconhento { get; }

        public int Idade() 
            => (DateTime.Now.Year - DataNascimento.Year);
        public void Alimentar() 
            => Console.WriteLine($"{Nome} está se alimentando.");
        
        public abstract void Movimentar();
        public abstract void Comunicar();
    }
}
