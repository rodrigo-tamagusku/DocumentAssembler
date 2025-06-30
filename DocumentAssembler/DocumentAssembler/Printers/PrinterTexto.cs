using DocumentAssembler.Modelos;
using System;

namespace DocumentAssembler.Printers
{
    public class PrinterTexto : IPrinter
    {
        public void Print(Node node)
        {
            if (node is Folha folha)
            {
                Console.WriteLine(folha.Texto);
            }
        }
    }
}
