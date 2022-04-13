using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhandoComArquivos.Helper
{
    public class fileHelper
    {
        public void listarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var dir in retornoCaminho)
            {
                System.Console.WriteLine(dir);
            }
        }

        public void listarArquivosDiretorios(string caminho)
        {
            //O * é um filtro para trazer tudo. Mas se quisermos selecionar o tipo de arquivos podemos colocar "*.txt"
            //Ou seja, "qualquerNome.txt"
            var retornoArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

            foreach (var dir in retornoArquivos)
            {
                System.Console.WriteLine(dir);
            }
        }
    }
}
