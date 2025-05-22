namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}