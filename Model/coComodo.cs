using cobOpus.ClasseBase;

namespace cobOpus
{
    public class coComodo : csModelBase
    {
        private caComodo objCaComodo;

        private int _cdComodo;

        public int cdComodo
        {
            get { return _cdComodo; }
            set { _cdComodo = value; }
        }
        private string _nmComodo = "";

        public string nmComodo
        {
            get { return _nmComodo; }
            set { _nmComodo = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public coComodo()
        {
            objCaComodo = new caComodo();
            AtualizaObj();
            LimparAtributos();
        }

        /// <summary>
        /// Método para garantir a execução das instruções no objeto correto
        /// </summary>
        public override void AtualizaObj()
        {
            base.AtualizaObj();
            objBanco.strCampoChave = objCaComodo.nmCampoChave;
            objBanco.strTabela = objCaComodo.nmTabela;
        }
    }
}
