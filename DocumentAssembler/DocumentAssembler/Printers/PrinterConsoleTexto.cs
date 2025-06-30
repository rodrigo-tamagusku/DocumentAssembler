using DocumentAssembler.Modelos;
using System;

namespace DocumentAssembler.Printers
{
    public class PrinterConsoleTexto : IPrinter
    {
        private const string NAO_DEFINIDO = "Não definido";

        public void Print(Node node)
        {
            string texto = NAO_DEFINIDO;
            if (node is Folha folha)
            {
                texto = folha.Texto;
            }
            Console.WriteLine($"Tipo: {node.GetType()}, Texto: {texto}");
        }
    }
}
