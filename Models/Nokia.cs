namespace Celular.Models
{
    public class Nokia : Smartphone
    {
        private string Modelo { get; }
        private string IMEI { get; }
        private int Memoria { get; }

        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero)
        {
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo {nome} pela Windows Store");
            for (int i = 0; i < nome.Length / 2; ++i)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }

            Console.WriteLine();
            Console.WriteLine("Applicativo instalado");
        }
    }
}
