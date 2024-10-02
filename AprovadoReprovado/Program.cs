using System;

using (StreamWriter escrever = new StreamWriter("jogos-mega-sena.txt"))

public class Program
{
    public static void Main()
    {
        do
        {
            // Declaração das variáveis
            float nota1, nota2, nota3, nota4;

            // Coletando as notas do aluno
            nota1 = LerNota("Insira a nota 1:");
            nota2 = LerNota("Insira a nota 2:");
            nota3 = LerNota("Insira a nota 3:");
            nota4 = LerNota("Insira a nota 4:");

            // Calculando a média
            float media = (nota1 + nota2 + nota3 + nota4) / 4;

            // Verificando a situação do aluno
            if (media < 0 || media > 10)
            {
                Console.WriteLine("Média inválida. As notas devem estar entre 0 e 10.");
            }
            else if (media < 6)
            {
                Console.WriteLine("O aluno está reprovado.");
            }
            else if (media >= 6 && media < 8)
            {
                Console.WriteLine("O aluno está de recuperação.");
            }
            else
            {
                Console.WriteLine("O aluno está aprovado.");
            }

            // Perguntar se o usuário deseja continuar
            Console.WriteLine("\nDeseja inserir as notas de outro aluno? (s/n)");
        } while (Console.ReadLine().Trim().ToLower() == "s");

        // Manter o console aberto
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    // Método para ler uma nota e validar a entrada
    private static float LerNota(string mensagem)
    {
        float nota;
        Console.WriteLine(mensagem);
        while (!float.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
        {
            Console.WriteLine("Nota inválida. Digite uma nota entre 0 e 10:");
        }
        return nota;
    }
}