using DocumentAssembler.Modelos;
using DocumentAssembler.Monitor;
using System;

namespace DocumentAssembler.Printers
{
    public class PrinterConsoleHorario : IPrinter
    {
        public void Print(Node node, int profundidade)
        {
            string texto =
                string.Format("{0}, {1}, {2}, {3}",
                    Monitoramento.Profundidade(profundidade),
                    Monitoramento.TipoNode(node),
                    Monitoramento.TempoCriacao(node),
                    Monitoramento.TempoExecucao());
            Console.WriteLine(texto);
        }
    }
}
