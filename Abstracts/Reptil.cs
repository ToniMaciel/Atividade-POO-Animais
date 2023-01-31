using System;

namespace Animals
{
    public abstract class Reptil : Animal, IOviparo
    {
        public abstract bool TemEscamas { get; }
        public abstract bool TemCasco { get; }

        public void Chocar() 
            => Console.WriteLine($"{Nome} está chocando um ovo.");
        public void Botar() 
            => Console.WriteLine($"{Nome} está botando um ovo");
    }
}
