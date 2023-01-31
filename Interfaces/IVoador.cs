namespace Animals
{
    public interface IVoador
    {
        int AltitudeMaximaEmMetros { get; }
        double VelocidadeDoVoo { get; }

        void Voar();
    }
}
