using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacas
{
    class Compra
    {
        private String _nr_compra;
        private String _nif;
        private String _montante;
        private String _data;
        private String _destino;
        private String _nrAnimal;

        public override string ToString()
        {
            return String.Format("{0,-15}  {1,-20}",_nrAnimal, _data);
        }

        public string Nif { get => _nif; set => _nif = value; }
        public string Montante { get => _montante; set => _montante = value; }
        public string Data { get => _data; set => _data = value; }
        public string Destino { get => _destino; set => _destino = value; }
        public string NrAnimal { get => _nrAnimal; set => _nrAnimal = value; }
        public string Nr_compra { get => _nr_compra; set => _nr_compra = value; }
    }
}
