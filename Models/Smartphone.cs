using System.Runtime.Serialization;
using System.Text;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo {get; set;}
        private string IMEI {get;set;}
        private int Memoria {get; set;}
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            this.Modelo=modelo;
            this.IMEI=imei;
            this.Memoria=memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"\n\tModelo= {this.Modelo}");
            sb.Append($"\n\tNumero= {this.Numero}");
            sb.Append($"\n\tIMEI= {this.IMEI}");
            sb.Append($"\n\tMemoria= {this.Memoria} GB");
            return sb.ToString();
        }
    }
}