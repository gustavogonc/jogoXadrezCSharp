using tabuleiro;
using xadrez;
using Xadrez_console;
using Xadrez_console.tabuleiro;

namespace XadrezConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                PosicaoXadrez pos = new PosicaoXadrez('a', 1);
                PosicaoXadrez pos2 = new PosicaoXadrez('c', 7);
                Console.WriteLine(pos.toPosicao());
                Console.WriteLine(pos2.toPosicao());
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Erro! " + e.Message);
            }
        }
    }
}
