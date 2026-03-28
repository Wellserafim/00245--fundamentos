using Fundamentos01;

namespace fundamentos01;

public class Aula01
{
    public void ExecutarAula()
    {
        // Início
        this.ExibirCabecalho();
        VariaveisEtiposDeDados variaveisEtiposDeDados = new VariaveisEtiposDeDados();
        variaveisEtiposDeDados.Executar();
        Console.WriteLine();

        // Operadores Aritiméticos
        OperadoresAritimeticos operadoresAritimeticos = new OperadoresAritimeticos();
        operadoresAritimeticos.executar();

        // Operadores de Comparação
        Console.WriteLine();
        OperadoresComparacao operadoresComparacao = new OperadoresComparacao();
        operadoresComparacao.Executar();

        // Operadore Lógicos
        Console.WriteLine();
        OperadoresLogicos operadoresLogicos = new OperadoresLogicos();
        operadoresLogicos.Executar();
        






        // Fim  
        this.ResumoAula();

    }


    private void ExibirCabecalho()
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("  Aula 01 - fundamentos de algoritimia ");
        Console.WriteLine("=======================================");
        Console.WriteLine();
    }

    private void ResumoAula()
    {
        Console.WriteLine();
        Console.WriteLine("=======================================");
        Console.WriteLine(" Fim da aula - resumo ");
        Console.WriteLine("=======================================");
        Console.WriteLine(" O que é algoritimia");
        Console.WriteLine(" Variáveis e tipos de dados");
        Console.WriteLine(" Operadores aritiméticos, comparação e lógicas");
        Console.WriteLine(" estrutura de controle básicos");
    }


} // Fim da aula01