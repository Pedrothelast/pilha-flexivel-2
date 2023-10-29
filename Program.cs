using System;

class Program
{
    public static void Main(string[] args)
    {
        string palavra = "radar"; // Substitua pela palavra que deseja verificar

        Pilha<char> pilha = new Pilha<char>();

        foreach (char c in palavra)
        {
            pilha.Push(c);
        }

        bool ehPalindromo = VerificarPalindromo(palavra, pilha);

        Console.WriteLine($"A palavra '{palavra}' é um palíndromo? {ehPalindromo}");

    }
}