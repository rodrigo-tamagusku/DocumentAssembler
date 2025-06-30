using DocumentAssembler.Modelos;
using DocumentAssembler.Printers;
using System;
using System.Collections.Generic;

namespace DocumentAssembler.Monitor
{
    public class Monitor : IMonitor
    {
        private const string TRACE = "TRACE";

        #region construtores
        public Monitor()
        {
            this.MonitoramentosString = new();
            this.MonitoramentosInt = new();
            this.MonitoramentosNode = new();
            this.MonitoramentosPrinter = new();
        }
        #endregion
        public string MonitoramentoAtual { get; private set; }
        public List<Func<string>> MonitoramentosString { get; private set; }
        public List<Func<int, string>> MonitoramentosInt { get; private set; }
        public List<Func<Node, string>> MonitoramentosNode { get; private set; }
        public List<Func<IPrinter, string>> MonitoramentosPrinter { get; private set; }
        #region Funções
        public void AdicionaMonitoramento(Func<string> monitoramento)
        {
            this.MonitoramentosString.Add(monitoramento);
        }
        public void AdicionaMonitoramento(Func<int, string> monitoramento)
        {
            this.MonitoramentosInt.Add(monitoramento);
        }
        public void AdicionaMonitoramento(Func<Node, string> monitoramento)
        {
            this.MonitoramentosNode.Add(monitoramento);
        }
        public void AdicionaMonitoramento(Func<IPrinter, string> monitoramento)
        {
            this.MonitoramentosPrinter.Add(monitoramento);
        }
        public void Monitora(Node node, IPrinter printer, string chave, int profundidade)
        {
            string trackingTexto = $"[{chave ?? TRACE}]";
            foreach (var func in this.MonitoramentosString)
            {
                trackingTexto += $"\n\t{func.Invoke()}";
            }
            foreach (var func in this.MonitoramentosInt)
            {
                trackingTexto += $"\n\t{func.Invoke(profundidade)}";
            }
            foreach (var func in this.MonitoramentosNode)
            {
                trackingTexto += $"\n\t{func.Invoke(node)}";
            }
            foreach (var func in this.MonitoramentosPrinter)
            {
                trackingTexto += $"\n\t{func.Invoke(printer)}";
            }
            Console.WriteLine(trackingTexto);
            this.MonitoramentoAtual = trackingTexto;

        }
        #endregion Funções
    }
}
