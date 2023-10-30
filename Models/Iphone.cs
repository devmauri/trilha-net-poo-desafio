using System.Text;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) 
        : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            var sb= new StringBuilder($"\n\nInstalando aplicativos {nomeApp} em Iphone.");
            sb.Append("\nMarca: Apple");
            sb.Append(base.ToString());
            Console.WriteLine(sb.ToString());
        }
    }
}