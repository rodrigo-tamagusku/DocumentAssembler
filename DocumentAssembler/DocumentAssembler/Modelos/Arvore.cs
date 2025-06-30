using DocumentAssembler.Printers;
using System;
using System.Collections.Generic;

namespace DocumentAssembler.Modelos
{
    public class Arvore
    {
        private Node raiz;

        #region construtores
        public Arvore()
        {
        }

        public Arvore(Node raiz)
        {
            this.raiz = raiz;
        }
        #endregion

        #region Funções
        public void Print(IPrinter printer)
        {
            Console.WriteLine($"Iniciando Print {printer.GetType()}");
            printer.Print(raiz);
            Console.WriteLine($"Finalizando Print {printer.GetType()}");
        }
        public void Print(IEnumerable<IPrinter> printers)
        {
            foreach (IPrinter printer in printers)
            {
                this.Print(printer);
            }
        }
        #endregion
    }
}
