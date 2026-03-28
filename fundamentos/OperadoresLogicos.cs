namespace Fundamentos01;

public class OperadoresLogicos{

    public void Executar()
    {
        Console.WriteLine("Operadores lógicos");

        bool temIdade = true;
        bool temCarta = false;

         Console.WriteLine($"Tem idade? {temIdade}");
         Console.WriteLine($"Tem carta? {temCarta}");
         Console.WriteLine();
         Console.WriteLine($"Pode dirigir? (tem idade e Carta) -> {temIdade && temCarta} (AND)");
         Console.WriteLine($"Pode tentar tirar? (tem idade OU Carta) -> {temIdade || temCarta} (OR)");
         Console.WriteLine($"Não tem idade? (!tem idade) -> {!temIdade} (NOT)");


    }
    




} // Fim de class