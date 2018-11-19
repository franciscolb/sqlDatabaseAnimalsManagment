using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacas
{
    class RegistoVacinacao
    {
        private String _nrVacina;
        private String _nrAnimal;
        private String _nrVeterinario;
        private String _nome;
        private String _data;
        private String _local;

        public string NrVacina { get => _nrVacina; set => _nrVacina = value; }
        public string NrAnimal { get => _nrAnimal; set => _nrAnimal = value; }
        public string NrVeterinario { get => _nrVeterinario; set => _nrVeterinario = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Data { get => _data; set => _data = value; }
        public string Local { get => _local; set => _local = value; }

        public override string ToString()
        {
            return String.Format("{0,-16}  {1,-20}", NrAnimal, Nome);
        }
    }
}
