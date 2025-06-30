namespace DocumentAssembler.Modelos
{
    public class Folha : Node
    {
        public string Texto { get; set; }

        #region construtores
        public Folha() : base()
        {
        }
        public Folha(string texto)
        {
            this.Texto = texto;
        }
        #endregion construtores
    }
}
