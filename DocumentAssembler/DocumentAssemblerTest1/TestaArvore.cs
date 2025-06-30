using DocumentAssembler.Modelos;
using DocumentAssembler.Printers;

namespace DocumentAssemblerTest1
{
    public class TestaArvore
    {
        private Arvore arvore;

        [SetUp]
        public void Setup()
        {
            /*
                 raiz
                /    \
              1       2
             / \    /  \
            3  4   5   6
             */
            Node raiz = new();
            Node node1 = new();
            Node node2 = new();
            raiz.AdicionaFilho(node1);
            raiz.AdicionaFilho(node2);
            Node node3 = new Folha("Sou número 3");
            Node node4 = new Folha("Sou número 4");
            node1.AdicionaFilho(node3);
            node1.AdicionaFilho(node4);
            Node node5 = new Folha("Sou número 5");
            Node node6 = new Folha("Sou número 6");
            node2.AdicionaFilho(node5);
            node2.AdicionaFilho(node6);
            this.arvore = new Arvore(raiz);
        }

        [Test]
        public void PrintaNodesConsole()
        {
            PrinterConsoleTexto printer = new PrinterConsoleTexto();
            this.arvore.Print(printer);
        }
    }
}
