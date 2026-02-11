namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            
        }
        public string Numero { get; set; }

        
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        public List<string> Apps { get; set; } = new();


        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        

        public void InformacoesCelular()
        {
            Console.WriteLine($"Numero: {Numero}\nModelo: {Modelo}\n IMEI: {IMEI}\nMemória: {Memoria} GB");
        }

        public void ListarApps()
        {
            foreach(string app in Apps)
            {
                Console.WriteLine(app);
            }
        }
        
    }
}