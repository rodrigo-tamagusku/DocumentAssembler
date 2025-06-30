using System.Collections.Generic;

namespace DocumentAssembler.Modelos
{
    public class Node
    {
        public List<Node> Filhos {  get; protected set; }
        #region construtores
        public Node()
        {
            this.Filhos = new List<Node>();
        }
        #endregion

        #region Funções
        public void AdicionaFilho(Node filho)
        {
            this.Filhos.Add(filho);
        }
        #endregion Funções
    }
}
