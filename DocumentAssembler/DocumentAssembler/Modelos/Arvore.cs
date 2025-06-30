using DocumentAssembler.Monitor;
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
        private IMonitor monitor;

        #region construtores
        public Arvore()
        {
        }

        public Arvore(Node raiz)
        {
            this.raiz = raiz;
        }

        public Arvore(Node raiz, IMonitor monitor)
        {
            this.raiz = raiz;
            this.monitor = monitor;
        }
        #endregion

        #region Funções
        public void Print(IPrinter printer)
        {        
            PrintComFilhos(printer, raiz, 0);
        }

        public void PrintComFilhos(IPrinter printer, Node node, int profundidade)
        {
            this.monitor?.Monitora(node, printer, "Início");
            printer.Print(node, profundidade);
            foreach (Node filho in node.Filhos)
            {
                PrintComFilhos(printer, filho, profundidade + 1);
            }
            this.monitor?.Monitora(node, printer, "Fim");
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
