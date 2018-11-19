using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacas
{
    [Serializable()]
    public class Animal
    {
        private String _nrAnimal;
        private String _produtor;
        private String _progenitorMasc;
        private String _progenitorFem;
        private String _estadoVacinacao;
        private String _estadoAnalises;
        private String _nome;
        private String _dataNasc;
        private Boolean _vaca;
        private String _raca;
        private String _preco;
        private String _tipoVaca;

        

        public String nrAnimal{
            get { return _nrAnimal; }
            set { _nrAnimal = value;  }
        }

        public String produtor
        {
            get { return _produtor; }
            set { _produtor = value; }
        }

        public String progenitorMasc
        {
            get { return _progenitorMasc; }
            set { _progenitorMasc = value; }
        }

        public String progenitorFem
        {
            get { return _progenitorFem; }
            set { _progenitorFem = value; }
        }
        public String estadoVacinacao
        {
            get { return _estadoVacinacao; }
            set { _estadoVacinacao = value; }
        }
        public String estadoAnalises
        {
            get { return _estadoAnalises; }
            set { _estadoAnalises = value; }
        }
        public String nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public String dataNasc
        {
            get { return _dataNasc; }
            set { _dataNasc = value; }
        }

        public bool Vaca { get => _vaca; set => _vaca = value; }
        public string Raca { get => _raca; set => _raca = value; }
        public String Preco { get => _preco; set => _preco = value; }
        public string TipoVaca { get => _tipoVaca; set => _tipoVaca = value; }

        public override string ToString()
        {
            return String.Format("{0,-10}  {1,-20}", _nrAnimal, _nome);
        }

        public Animal() : base()
        {

        }
    }
}
