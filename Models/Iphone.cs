namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string Numero, string Modelo, string IMEI, int Memoria) : base(Numero, Modelo, IMEI, Memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O celular está baixando o aplicativo {nomeApp} pela appleStore, loja exclusiva do Iphone");
        }
    }
}