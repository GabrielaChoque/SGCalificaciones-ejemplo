using SGCalificaciones.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCalificaciones.Controlador
{
    class EstudianteController
    {
        BdCalificacionesEntities _db = new BdCalificacionesEntities();

        public List<Estudiante> Listar(string pBuscar)
        {
            return _db.Estudiante.Where(x => x.nombre.Contains(pBuscar)).ToList();
        }
        public bool Insertar(Data.Estudiante reg)
        {
            _db.Estudiante.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Estudiante reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Eliminar(int pParametro)
        {
            var reg = _db.Estudiante.Where(x => x.nro_carnet == pParametro).FirstOrDefault();
            _db.Estudiante.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        internal List<Estudiante> BuscarPorPK(int pCuenta)
        {
            return _db.Estudiante.Where(x => x.nro_carnet == pCuenta).ToList();
        }
    }
}
