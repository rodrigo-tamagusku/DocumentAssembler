using DocumentAssembler.Modelos;
using DocumentAssembler.Monitor;
using System;

namespace DocumentAssembler.Printers
{
    public class PrinterConsoleTexto : IPrinter
    {
        public void Print(Node node, int profundidade)
        {
            Console.WriteLine($"{Monitoramento.TipoNode(node)}, {Monitoramento.TextoNode(node)}");
        }
    }
}
