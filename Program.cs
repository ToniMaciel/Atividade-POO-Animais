using System;

namespace Animais
{
    public class Leao : Mamifero
    {
        public override bool Carnivoro 
            => true;
        public override bool Peconhento 
            => false;

        public override void Movimentar() 
            => Console.WriteLine($"{Nome} está correndo.");
        public override void Comunicar() 
            => Console.WriteLine($"{Nome} está rugindo. (PST)");

        public override int QuantidadeMamas 
            => 4;
        public override bool Pelos 
            => true;
        public override string CorPelo 
            => "Amarelo";
    }

    public class Chacal : Mamifero
    {
        public override bool Carnivoro 
            => true;
        public override bool Peconhento 
            => false;

        public override void Movimentar() 
            => Console.WriteLine($"{Nome} está correndo.");
        public override void Comunicar() 
            => Console.WriteLine($"{Nome} está fazendo comunicação de chacal.");

        public override int QuantidadeMamas 
            => 4;
        public override bool Pelos 
            => true;
        public override string CorPelo 
            => "Bege";
    }

    public class Morcego : Mamifero, IVoador
    {
        public override bool Carnivoro 
            => false;
        public override bool Peconhento 
            => false;

        public override void Movimentar() 
            => Voar();
        public override void Comunicar() 
            => Console.WriteLine($"{Nome} está emitindo sons de morcego.");

        public override int QuantidadeMamas 
            => 2;
        public override bool Pelos 
            => true;
        public override string CorPelo 
            => "Preto";

        public int AltitudeMaxima 
            => 1000;
        public double VelocidadeMaxima 
            => 150;
        public void Voar() 
            => Console.WriteLine($"{Nome} está voando.");
    }

    public class Cisne : Ave, IVoador, IAquatico
    {
        public override bool Carnivoro 
            => false;
        public override bool Peconhento 
            => false;

        public override void Movimentar() 
            => Console.WriteLine($"{Nome} está nadando.");
        public override void Comunicar() 
            => Console.WriteLine($"{Nome} está cantando.");

        public override bool Rapina 
            => false;
        public override string CorPena 
            => "Branco";

        public int AltitudeMaxima 
            => 500;
        public double VelocidadeMaxima 
            => 70.8d;
        public void Voar() 
            => Console.WriteLine($"{Nome} está voando.");

        public bool ViveEmTerra 
            => true;
        public bool Mergulho 
            => false;
        public bool AguaDoce 
            => true;
    }

    public class Arara : Ave, IVoador
    {
        public override bool Carnivoro 
            => false;
        public override bool Peconhento
            => false;

        public override void Movimentar() 
            => Voar();
        public override void Comunicar() 
            => Console.WriteLine($"{Nome} está ararando.");

        public override bool Rapina 
            => false;
        public override string CorPena 
            => "Azul";

        public int AltitudeMaxima 
            => 2300;
        public double VelocidadeMaxima 
            => 50.6d;
        public void Voar() 
            => Console.WriteLine($"{Nome} está voando.");
    }

    public class DragaoComodo : Reptil
    {
        public override bool Carnivoro 
            => true;
        public override bool Peconhento 
            => true;

        public override void Movimentar() 
            => Console.WriteLine($"{Nome} está andando.");
        public override void Comunicar() 
            => Console.WriteLine($"{Nome} está emitindo sons de dragão de comodo.");

        public override bool TemEscamas 
            => true;
        public override bool TemCasco
            => false;

    }

    public class Lontra : Mamifero, IAquatico
    {
        public override bool Carnivoro 
            => true;
        public override bool Peconhento 
            => false;

        public override void Movimentar() 
            => Console.WriteLine($"{Nome} está nadando.");
        public override void Comunicar() 
            => Console.WriteLine($"{Nome} está fazendo sons fofos de Lontra.");

        public override int QuantidadeMamas 
            => 4;
        public override bool Pelos 
            => true;
        public override string CorPelo 
            => "Marrom";

        public bool ViveEmTerra
            => true;
        public bool Mergulho
            => true;
        public bool AguaDoce
            => true;
    }

    public class Pinguim : Ave, IAquatico
    {
        public override bool Carnivoro 
            => true;
        public override bool Peconhento 
            => false;

        public override void Movimentar() 
            => Console.WriteLine($"{Nome} está andando.");
        public override void Comunicar() 
            => Console.WriteLine($"{Nome} está cantando.");

        public override bool Rapina 
            => false;
        public override string CorPena 
            => "Preto";

        public bool ViveEmTerra 
            => true;
        public bool Mergulho 
            => true;
        public bool AguaDoce 
            => false;
    }

    public class Coruja : Ave, IVoador
    {
        public override bool Carnivoro 
            => true;
        public override bool Peconhento 
            => false;

        public override void Movimentar() 
            => Voar();
        public override void Comunicar() 
            => Console.WriteLine($"{Nome} está piando.");

        public override bool Rapina 
            => true;
        public override string CorPena 
            => "Marrom";

        public int AltitudeMaxima 
            => 500;
        public double VelocidadeMaxima 
            => 50.7d;
        public void Voar() 
            => Console.WriteLine($"{Nome} está voando.");
    }

    public class Elefante : Mamifero
    {
        public override bool Carnivoro 
            => false;
        public override bool Peconhento 
            => false;

        public override void Movimentar() 
            => Console.WriteLine($"{Nome} está andando.");
        public override void Comunicar() 
            => Console.WriteLine($"{Nome} está fazendo sons com sua tromba.");

        public override int QuantidadeMamas 
            => 2;
        public override bool Pelos 
            => true;
        public override string CorPelo 
            => "Cinza";
    }

    public class Jacare : Reptil, IAquatico
    {
        public override bool Carnivoro 
            => true;
        public override bool Peconhento 
            => false;

        public override void Movimentar() 
            => Console.WriteLine($"{Nome} está nadando.");
        public override void Comunicar() 
            => Console.WriteLine($"{Nome} está fazendo sons de jacaré.");

        public override bool TemEscamas 
            => true;
        public override bool TemCasco 
            => false;

        public bool ViveEmTerra 
            => true;
        public bool Mergulho 
            => true;
        public bool AguaDoce 
            => true;
    }

    public class Ornitorrinco : Mamifero, IAquatico, IOviparo
    {
        public override bool Carnivoro 
            => true;
        public override bool Peconhento 
            => true;

        public override void Movimentar() 
            => Console.WriteLine($"{Nome} está nadando.");
        public override void Comunicar() 
            => Console.WriteLine($"{Nome} está fazendo prrrr (referência de Phineas e Ferb).");

        public override int QuantidadeMamas 
            => 0;
        public override bool Pelos 
            => true;
        public override string CorPelo 
            => "Marrom";

        public bool ViveEmTerra 
            => true;
        public bool Mergulho 
            => true;
        public bool AguaDoce 
            => true;

        public void Chocar() 
            => Console.WriteLine($"{Nome} está chocando um ovo.");
        public void Botar()
            => Console.WriteLine($"{Nome} está botando um ovo.");
    }
}
