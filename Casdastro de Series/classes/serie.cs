using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casdastro_de_Series.classes
{
    class Serie:EntidadeClass
    {
        private readonly string[] _campos = new string[] {"Titulo:","Descricao:","Genero:","Ano:" };
 
        public string _Titulo { get; set; }
        public string _Descricao { get; set; }
        public int _Ano { get; set; }
        public bool _Excluido { get; set; }
        public Generos _Genero { get; set; } = new Generos();

        public Serie(int id,Generos generos,string titulo, int ano,string descicao,bool excluida)
        {
            Id = id;
            _Ano = ano;
            _Descricao = descicao;
            _Genero = generos;
            _Titulo = titulo;
            _Excluido = excluida;

        }
        public override string ToString()
        {
            string retorno = "";
            dynamic[] CamposAlvos = new dynamic[] {_Titulo,_Descricao,_Genero,_Ano};

            for (int i = 0; i < _campos.Length; i++)
            {
                if (_Excluido == false)
                {
                    retorno += _campos[i] + CamposAlvos[i] + Environment.NewLine;
                }
            }

            return retorno;
        }
        public void Exclui()
        {
            _Excluido = true;
        }
    }
}
