using DocumentAssembler.Modelos;
using DocumentAssembler.Printers;

namespace DocumentAssembler.Monitor
{
    public interface IMonitor
    {
        public void Monitora(Node node, IPrinter printer, string chave);
    }
}
