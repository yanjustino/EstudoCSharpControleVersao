using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstudoCSharp.Sistema
{
    public class Sistema
    {
        public double Versao { get; set; }
        
        /*
         * Verifica se a versão é desenvolvimento.
         * A versão é desenvolvimento se seu valor for menor que 1.0
         */
        public bool isVersaoDesenvolvimento()
        {
            return this.Versao < 1.0;
        }

        /*
         * Verifica se a versão é beta.
         * A versão é beta se seu valor for menor ou igual a 2.0
         */
        public bool isVersaoBeta()
        {
            return this.Versao <= 2.0;
        }

        /*
         * Verifica se a versão Final.
         * A versão é final se seu valor for maior que 2.0
         */
        public bool isVersaoFinal()
        {
            return this.Versao > 2.0;
        }
    }
}
