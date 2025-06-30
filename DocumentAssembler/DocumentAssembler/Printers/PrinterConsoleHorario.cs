using DocumentAssembler.Modelos;
using System;

namespace DocumentAssembler.Printers
{
    public class PrinterConsoleHorario : IPrinter
    {
        public void Print(Node node)
        {
            string texto =
                string.Format("{0}, {1}, {2}",
                $"Tipo: {node.GetType()}",
                $"Horario Criação: {node.HorarioCriacao}",
                $"Horario Atual: {DateTime.Now}");
            Console.WriteLine(texto);
            foreach (Node filho in node.Filhos)
            {
                this.Print(filho);
            }
        }
    }
}
