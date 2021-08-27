using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casdastro_de_Series.Interfaces;

namespace Casdastro_de_Series.classes
{
    class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> _listSerie = new List<Serie>();

        internal List<Serie> ListSerie { get => _listSerie; set => _listSerie = value; }

        public void Atualiza(int id, Serie entidade)
        {
            ListSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            _listSerie[id].Exclui();
        }

        public void Insere(Serie entidade)
        {
            _listSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return _listSerie;
        }

        public int ProximoId()
        {
            return _listSerie.Count;
        }

        public Serie RetornoId(int id)
        {
            return _listSerie[id];
        }
    }
}
