using System;

namespace Animals
{
    public abstract class Mamifero : Animal
    {
        public abstract int QtdMamas { get; }
        public abstract bool Pelos { get; }
        public abstract string CorPelo { get; }

        public void Amamentar()
            => Console.WriteLine($"{Nome} está amamentando.");
    }
}
