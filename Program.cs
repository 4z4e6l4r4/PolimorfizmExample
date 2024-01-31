namespace PolimorfizmExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape;

            //Şekilden türemiş Daire objesi
            shape = new Daire();
            shape.Ciz();

            shape = new Kare();
            shape.Ciz();
        }
    }
}
