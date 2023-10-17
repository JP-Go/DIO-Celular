namespace Celular.Models
{
    public class Iphone : Smartphone
    {
        private string Modelo { get; }
        private string IMEI { get; }
        private int Memoria { get; }

        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero)
        {
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo {nome} pela AppStore");
            for (int i = 0; i < nome.Length / 3; ++i)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }

            Console.WriteLine();
            Console.WriteLine("Applicativo instalado");
        }
    }
}
