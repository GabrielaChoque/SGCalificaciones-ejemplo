using SGCalificaciones.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCalificaciones.Controlador
{
    class CursoController
    {
        BdCalificacionesEntities _db = new BdCalificacionesEntities();

        public List<Curso> Listar(string pBuscar)
        {
            return _db.Curso.Where(x => x.nom_curso.Contains(pBuscar)).ToList();
        }
        public bool Insertar(Data.Curso reg)
        {
            _db.Curso.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Curso reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Eliminar(int pParametro)
        {
            var reg = _db.Curso.Where(x => x.nro_carnet == pParametro).FirstOrDefault();
            _db.Curso.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        internal List<Curso> ListarCurso(int pCuenta)
        {
            /*var _db.Curso.Join(_db.Plantel_Educativo,
                                       c => c.nro_carnet,
                                       p => p.nro_carnet,
                                       (c, p) => new
                                       {
                                           id_curso = c.id_curso,
                                           nom_curso = c.nom_curso,
                                           nro_carnet = c.nro_carnet,
                                           nombre = string.Join(p.nombre, p.ap_paterno, p.ap_materno)
                                       }
                      ).ToList();*/
          return _db.Curso.Where(x => x.nro_carnet == pCuenta).ToList();
          // var consulta = (from Curso )
        }
    }
}
