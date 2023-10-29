using System.Xml.Linq;

class Pilha
{
    private Celula topo;
    public Pilha()
    {
        topo = null;
    }
    public void Inserir(int x)
    {
        Celula tmp = new Celula(x);
        tmp.Prox = topo;
        topo = tmp;
        tmp = null;
    }
    public int Remover()
    {
        if (topo == null)
            throw new Exception("Erro!");
        int elemento = topo.Elemento;
        Celula tmp = topo;
        topo = topo.Prox;
        tmp.Prox = null;
        tmp = null;
        return elemento;
    }
    public void Mostrar()
    {
        Console.Write("[ ");
        for (Celula i = topo; i != null; i = i.Prox)
        {
            Console.Write(i.Elemento + " ");
        }
        Console.WriteLine("]");
    }

    static bool VerificarPalindromo(string palavra, Pilha<char> pilha)
    {
        int tamanho = palavra.Length;

        for (int i = 0; i < tamanho; i++)
        {
            char caracterePilha = pilha.Pop();
            char caracterePalavra = palavra[i];

            if (caracterePilha != caracterePalavra)
            {
                // Se os caracteres não forem iguais, não é um palíndromo
                return false;
            }
        }

        // Se todos os caracteres forem iguais, é um palíndromo
        return true;
    }
}
}

