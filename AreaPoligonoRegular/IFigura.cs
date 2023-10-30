namespace ConsoleApp
{
    internal interface IFigura
    {
        public int NumeroLados { get; }
        public double LongitudLados { get; }
        //public double AnguloCentral { get => 360 / NumeroLados; }
        public double Apotema => LongitudLados / (2.0 * Math.Tan(Math.PI / NumeroLados));
        public double Perimetro { get => NumeroLados * LongitudLados; }
        public double Area { get => (Perimetro * Apotema) / 2; }

    }
}
