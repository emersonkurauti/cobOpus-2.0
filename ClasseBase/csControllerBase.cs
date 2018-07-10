using System.Data;

namespace cobOpus.ClasseBase
{
    public class csControllerBase
    {
        protected string _strMensagemErro;
        public string strMensagemErro
        {
            get { return _strMensagemErro; }
            set { _strMensagemErro = value; }
        }

        protected DataTable _dtDados;
        public DataTable dtDados
        {
            get { return _dtDados; }
            set { _dtDados = value; }
        }

        protected csModelBase _objModelo;
        public csModelBase objModelo
        {
            get { return _objModelo; }
            set { _objModelo = value; }
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public bool Select()
        {
            _strMensagemErro = "";

            if (!_objModelo.Select(out _dtDados))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Inserir
        /// </summary>
        /// <returns></returns>
        public bool Inserir()
        {
            if (!_objModelo.Inserir())
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Alterar
        /// </summary>
        /// <returns></returns>
        public bool Alterar()
        {
            _strMensagemErro = "";

            if (!_objModelo.Alterar())
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Excluir
        /// </summary>
        /// <returns></returns>
        public bool Excluir()
        {
            _strMensagemErro = "";

            if (!_objModelo.Excluir())
            {
                return false;
            }
            return true;
        }
    }
}
