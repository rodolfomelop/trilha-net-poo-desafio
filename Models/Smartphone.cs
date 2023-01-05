namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        
        public Smartphone()
        {
            
        }
        public Smartphone(string numero)
        {
            Numero = numero;
        // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}