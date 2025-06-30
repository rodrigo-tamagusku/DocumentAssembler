namespace DocumentAssembler.Modelos
{
    public class Folha : Node
    {
        private string texto;

        #region construtores
        public Folha() : base()
        {
        }
        public Folha(string texto) : base(texto)
        {
            this.texto = texto;
        }
        #endregion construtores
    }
}
