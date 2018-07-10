using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobOpus
{
    public class caComodo
    {
        public string nmTabela
        {
            get { return "cobComodos"; }
        }

        public string nmCampoChave
        {
            get { return "cdComodo"; }
        }

        public string cdComodo
        {
            get { return "cdComodo"; }
        }

        public string nmComodo
        {
            get { return "nmComodo"; }
        }

        /// <summary>
        /// Retorna fields para montar DataGridView
        /// </summary>
        /// <param name="strFields"></param>
        /// <param name="strVisivel"></param>
        /// <param name="strNome"></param>
        public void RetornarFields(out string strFields, out string strVisivel, out string strNome)
        {
            strFields = cdComodo + "," + nmComodo;

            strNome = "Código, Nome do cômodo";

            strVisivel = "0,1";
        }
    }
}
