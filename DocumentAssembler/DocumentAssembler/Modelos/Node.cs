using System.Collections.Generic;

namespace DocumentAssembler.Modelos
{
    public class Node
    {
        private List<Node> filhos;
        #region construtores
        public Node()
        {
            this.filhos = new List<Node>();
        }
        #endregion

        #region Funções
        public void AdicionaFilho(Node filho)
        {
            this.filhos.Add(filho);
        }
        #endregion Funções
    }
}
