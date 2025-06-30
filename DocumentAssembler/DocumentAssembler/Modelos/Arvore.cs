using DocumentAssembler.Printers;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;

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
            PrintComFilhos(printer, raiz, 0);
            Console.WriteLine($"Finalizando Print {printer.GetType()}");
        }

        public static void PrintComFilhos(IPrinter printer, Node node, int profundidade)
        {
            printer.Print(node, profundidade);
            foreach (Node filho in node.Filhos)
            {
                PrintComFilhos(printer, filho, profundidade + 1);
            }
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
