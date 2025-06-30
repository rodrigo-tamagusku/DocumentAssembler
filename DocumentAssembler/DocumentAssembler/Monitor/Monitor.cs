using DocumentAssembler.Modelos;
using DocumentAssembler.Printers;
using System;

namespace DocumentAssembler.Monitor
{
    public class Monitor : IMonitor
    {
        private const string TRACE = "TRACE";

        #region construtores
        public Monitor()
        {
        }
        #endregion
        public string MonitoramentoAtual { get; private set; }
        #region Funções
        public void Monitora(Node node, IPrinter printer, string chave)
        {
            string monitoramentoAtual = $"{DateTime.Now} [{chave ?? TRACE}] {printer.GetType()}";
            Console.WriteLine(monitoramentoAtual);
            this.MonitoramentoAtual = monitoramentoAtual;

        }
        #endregion Funções
    }
}
