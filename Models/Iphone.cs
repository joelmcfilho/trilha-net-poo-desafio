namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // Implementado!!
    public class Iphone : Smartphone
    {
        private string Modelo;
        private string Imei;
        private int Memoria;
        public Iphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public override void Informacoes()
        {
            Console.WriteLine("---- INFORMAÇÕES DO TELEFONE ----");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Nº de IMEI: {Imei}");
            Console.WriteLine($"Cap. Memória Interna: {Memoria} GB");
            Console.WriteLine($"Número Cadastrado: {Numero}");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Implementado!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Acessando a Apple Store...");
            Console.WriteLine($"Baixando e instalando {nomeApp}...");
            Console.WriteLine($"{nomeApp} instalado com sucesso!");
        }
    }
}