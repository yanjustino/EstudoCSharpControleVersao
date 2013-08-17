
using System;
namespace EstudoCSharp.Sistema
{
    /*
     * Classe Sistema implementada no arquivo Sistema.java
     */
    class ControladorSistema
    {
        static void Main(string[] args)
        {
            Sistema sistema = new Sistema();
            sistema.Versao = 1.0;

            /*
             * Método pra mostrar qual é a versão do sistema Implementado logo
             * abaixo do método Main
             */
            MensagemDaVersaoDoSistema(sistema);

            /*
             * Fazendo upgrade de versão com while
             */
            while (sistema.Versao < 10)
            {
                double versao = sistema.Versao;
                Console.WriteLine(versao);
                sistema.Versao += 1;
            }

            /*
             * Método pra mostrar qual é a versão do sistema Implementado logo
             * abaixo do método Main
             */
            MensagemDaVersaoDoSistema(sistema);
            Console.Read();
        }

        /*
         * Método pra mostrar qual é a versão do sistema Recebe por parâmetro um
         * Sistema
         */
        public static void MensagemDaVersaoDoSistema(Sistema sistema)
        {
            if (sistema.isVersaoDesenvolvimento())
                Console.WriteLine("ATENÇÃO : Versão do sitema é de desenvolvimento");

            else if (sistema.isVersaoBeta())
                Console.WriteLine("ATENÇÃO : Versão do sitema é beta");

            else if (sistema.isVersaoFinal())
                Console.WriteLine("ATENÇÃO : Versão do sitema é a Final");
        }
    }
}
