using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacas
{
    class producaoLeite
    {
        private String _produtor;
        private String _producaoManha;
        private String _producaoTarde;
        private String _data;
        private String _fabrica;
        private String _preco;


        public producaoLeite()
        {

        }
        public string Produtor { get => _produtor; set => _produtor = value; }
        public string ProducaoManha { get => _producaoManha; set => _producaoManha = value; }
        public string ProducaoTarde { get => _producaoTarde; set => _producaoTarde = value; }
        public string Data { get => _data; set => _data = value; }
        public string Fabrica { get => _fabrica; set => _fabrica = value; }
        public string Preco { get => _preco; set => _preco = value; }

        override
        public String ToString()
        {
            return String.Format("{0,-20:C}{1,-20:C}{2,-15:C}", _data, _producaoManha, _producaoTarde);
        }
    }
}
