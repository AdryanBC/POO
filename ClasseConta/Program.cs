using ClasseConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Exemplos de instâncias...");
        // declaração da variável c1, do tipo Conta
        Conta c1;
        // instancia de 1 objeto
        // c1 esta recebendo uma alocação de memória com a instrução "new" e chamando o construtor da classe "Conta()"
        c1 = new Conta();
        // para utilizar o objeto:
        c1.numero = 19;
        c1.titular = "Ana";
        c1.saldo = 109.10;

        c1.MostrarAtributos();        
        // exibição otimizada
        Console.Write("Informe o valor a sacar: ");
        double saque = Convert.ToDouble(Console.ReadLine());
        // saque é um argumento do método (função)
        c1.Sacar(saque);
        c1.MostrarAtributos();
        // instanciação do objeto c2

        Conta c2 = new Conta();
        Console.Write("Informe o número: ");
        c2.numero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o titular: ");
        c2.titular = Console.ReadLine();
        Console.Write("Informe o saldo: ");
        c2.saldo = Convert.ToDouble(Console.ReadLine());

        c2.MostrarAtributos();
        // exibição otimizada
    }
}