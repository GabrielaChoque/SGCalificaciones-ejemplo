using SGCalificaciones.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCalificaciones.Controlador
{
    class BimestreController
    {
        BdCalificacionesEntities _db = new BdCalificacionesEntities();

        public List<Bimestre> Listar(string pBuscar)
        {
            return _db.Bimestre.Where(x => x.bimestre.Contains(pBuscar)).ToList();
        }
        public bool Insertar(Data.Bimestre reg)
        {
            _db.Bimestre.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Bimestre reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Eliminar(int pParametro)
        {
            var reg = _db.Bimestre.Where(x => x.id_bimestre == pParametro).FirstOrDefault();
            _db.Bimestre.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        internal List<Bimestre> BuscarPorPK(string pCuenta)
        {
            return _db.Bimestre.Where(x => x.bimestre == pCuenta).ToList();
        }

    }
}
