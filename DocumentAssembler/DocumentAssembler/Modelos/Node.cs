using System;
using System.Collections.Generic;

namespace DocumentAssembler.Modelos
{
    public class Node
    {
        public DateTime HorarioCriacao { get; }
        public List<Node> Filhos { get; }
        #region construtores
        public Node()
        {
            this.HorarioCriacao = DateTime.Now;
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
