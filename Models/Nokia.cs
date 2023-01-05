namespace DesafioPOO.Models
{

    public class Nokia : Smartphone
    {

        public Nokia()
        {

        }
        public Nokia(string numero) : base(numero)
        {

        }

         public Nokia(string numero, string Modelo, string IMEI, int Memoria) : base(numero)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }
    }
}