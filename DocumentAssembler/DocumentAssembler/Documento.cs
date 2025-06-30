namespace DocumentAssembler
{
    public class Documento
    {
        private Arvore arvore;

        #region construtores
        public Documento()
        {
        }

        public Documento(Arvore arvore)
        {
            this.arvore = arvore;
        }
        #endregion
    }
}
