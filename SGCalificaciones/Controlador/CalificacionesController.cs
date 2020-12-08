using SGCalificaciones.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCalificaciones.Controlador
{
    class CalificacionesController
    {
        BdCalificacionesEntities _db = new BdCalificacionesEntities();

        public int ListarCalif(int pCi,int pIdMat, int  pIdBim)
        {
            var reg = _db.Calificaciones.Where(x => x.nro_carnet == pCi && x.id_materia==pIdMat && x.id_bimestre == pIdBim).FirstOrDefault();
            if (reg==null)
               return 0;
            else
               return Convert.ToInt32(reg.calificacion);
        }
        /*
        public List<Calificaciones> Listar(string pBuscar)
        {
            return _db.Calificaciones.Where(x => x.calificacion.Contains(pBuscar)).ToList();
        }*/
        public bool Insertar(Data.Calificaciones reg)
        {
            _db.Calificaciones.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Calificaciones reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }

        public int IdCalificacion(int pCi, int pIdMat, int pIdBim)
        {
            var reg = _db.Calificaciones.Where(x => x.nro_carnet == pCi && x.id_materia == pIdMat && x.id_bimestre == pIdBim).FirstOrDefault();
            if (reg == null)
                return 0;
            else
                return Convert.ToInt32(reg.id_calificacion);
        }
        internal List<Calificaciones> BuscarPorPK(int pCalif)
        {
            return _db.Calificaciones.Where(x => x.id_calificacion == pCalif).ToList();            
           
        }
        internal int promedio(int pCalif)
        {
            var query = _db.Calificaciones.Where(x => x.nro_carnet==pCalif );

            var r = new
            {
                aveValue1 = query.Average(x => x.calificacion)
            };
            return Convert.ToInt32(r.aveValue1);
        }
    }
}
