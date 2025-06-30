using DocumentAssembler.Modelos;

namespace DocumentAssembler.Printers
{
    public interface IPrinter
    {
        public void Print(Node node, int profundidade);
    }
}
