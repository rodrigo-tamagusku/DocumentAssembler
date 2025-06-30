using DocumentAssembler.Modelos;
using DocumentAssembler.Printers;
using System;

namespace DocumentAssembler.Monitor
{
    public interface IMonitor
    {
        void Monitora(Node node, IPrinter printer, string chave, int profundidade);
        void AdicionaMonitoramento(Func<string> monitoramento);
        void AdicionaMonitoramento(Func<int, string> monitoramentoProfundidade);
        void AdicionaMonitoramento(Func<Node, string> monitoramentoTipoNode);
        void AdicionaMonitoramento(Func<IPrinter, string> monitoramentoTipoNode);
    }
}
