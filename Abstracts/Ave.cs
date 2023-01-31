using System;

namespace Animals
{
    public abstract class Ave : Animal, IOviparo
    {
        public abstract bool Rapina { get; }
        public abstract string CorPena { get; }

        public void Ciscar() 
            => Console.WriteLine($"{Nome} est� ciscando.");

        public void Chocar() 
            => Console.WriteLine($"{Nome} est� chocando um ovo.");
        public void Botar() 
            => Console.WriteLine($"{Nome} est� botando um ovo.");
    }
}
