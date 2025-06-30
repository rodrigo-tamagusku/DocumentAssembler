using DocumentAssembler.Modelos;
using System;

namespace DocumentAssembler.Printers
{
    public class PrinterConsoleHorario : IPrinter
    {
        public void Print(Node node, int profundidade)
        {
            string texto =
                string.Format("{0}, {1}, {2}, {3}",
                    $"Profundidade: {profundidade}",
                    $"Tipo: {node.GetType()}",
                    $"Horario Criação: {node.HorarioCriacao}",
                    $"Horario Atual: {DateTime.Now}");
            Console.WriteLine(texto);
        }
    }
}
