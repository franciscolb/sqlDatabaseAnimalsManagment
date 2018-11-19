using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacas
{
    class Pessoa
    {
        private int _nif;
        private String _name;
        private char _sexo;
        private String _localidade;
        private String _data_nasc;
        private int _tel;
        private String _email;

        public Pessoa(int nif, string name, char sexo, string localidade, string data_nasc, int tel, string email)
        {
            _nif = nif;
            _name = name;
            _sexo = sexo;
            _localidade = localidade;
            _data_nasc = data_nasc;
            _tel = tel;
            _email = email;
        }
        public Pessoa ()
        {

        }

        public override string ToString()
        {
            return String.Format("{0}    {1}", _nif, _name);
        }

        public int Nif { get => _nif; set => _nif = value; }
        public string Name { get => _name; set => _name = value; }
        public char Sexo { get => _sexo; set => _sexo = value; }
        public string Localidade { get => _localidade; set => _localidade = value; }
        public string Data_nasc { get => _data_nasc; set => _data_nasc = value; }
        public int Tel { get => _tel; set => _tel = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
