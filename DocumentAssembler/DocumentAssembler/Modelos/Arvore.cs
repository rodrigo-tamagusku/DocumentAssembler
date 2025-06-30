using DocumentAssembler.Printers;

namespace DocumentAssembler.Modelos
{
    public class Arvore
    {
        private Node raiz;

        #region construtores
        public Arvore()
        {
        }

        public Arvore(Node raiz)
        {
            this.raiz = raiz;
        }
        #endregion

        #region Funções
        public void Print(IPrinter printer)
        {
            printer.Print(raiz);
        }
        #endregion
    }
}
