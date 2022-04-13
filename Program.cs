using System;
using trabalhandoComArquivos.Helper;

namespace trabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\Users\\adrie\\Documents\\Desenvolvimento\\PilaresPOO\\PastaTeste1";

            fileHelper helper = new fileHelper();
            helper.listarDiretorios(caminho);
            helper.listarArquivosDiretorios(caminho);
           
        }
    }
}

