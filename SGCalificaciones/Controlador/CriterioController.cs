using SGCalificaciones.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCalificaciones.Controlador
{
    class CriterioController
    {
        BdCalificacionesEntities _db = new BdCalificacionesEntities();

        public List<Criterio> Listar(string pBuscar)
        {
            return _db.Criterio.Where(x => x.desc_criterio.Contains(pBuscar)).ToList();
        }
        public bool Insertar(Data.Criterio reg)
        {
            _db.Criterio.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Criterio reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Eliminar(int pParametro)
        {
            var reg = _db.Criterio.Where(x => x.id_criterio == pParametro).FirstOrDefault();
            _db.Criterio.Remove(reg);
            return _db.SaveChanges() > 0;
        }
    }
}
