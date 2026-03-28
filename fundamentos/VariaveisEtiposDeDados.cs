namespace Fundamentos01;

public class VariaveisEtiposDeDados
{
    string sobreNome = "Jesus";

    public void Executar()
    {
        Console.WriteLine("  VARIÁVEIS E TIPOS DE DADOS ");
        Console.WriteLine(" Variáveis são espaços na memória para guaradar informações. ");
        Console.WriteLine();

        int idade = 25;
        double altura = 1.75;
        float media = 1950;
        char letra = 'A';
        string nome = "Well";
        string nomeComposto = nome + "Filho"; // Concatenação
        bool estudante = true;
        

        Console.WriteLine($"int -> idade: {idade} (números inteiros)");
        Console.WriteLine($"double -> altura: {altura} (número decimais)");
        Console.WriteLine($"char -> letra: {letra} (um único caracter)");
        Console.WriteLine($"string -> nome: {nomeComposto} (texto)");
        Console.WriteLine($"variável global -> sobreNome: {this.sobreNome} (Variável Global)");
        Console.WriteLine($"bool -> estudante: {estudante} (boolenano ou seja Verdadeiro ou Falso)");



    }




}// Fim da class