using SGCalificaciones.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCalificaciones.Controlador
{
    class MateriaController
    {
        BdCalificacionesEntities _db = new BdCalificacionesEntities();

        public List<Materia> Listar(string pBuscar)
        {
            return _db.Materia.Where(x => x.nombre_materia.Contains(pBuscar)).ToList();
        }
        public bool Insertar(Data.Materia reg)
        {
            _db.Materia.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Materia reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Eliminar(int pParametro)
        {
            var reg = _db.Materia.Where(x => x.id_materia == pParametro).FirstOrDefault();
            _db.Materia.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        internal List<Materia> BuscarPorPK(int pCuenta)
        {
            return _db.Materia.Where(x => x.id_materia == pCuenta).ToList();
        }
    }
}
