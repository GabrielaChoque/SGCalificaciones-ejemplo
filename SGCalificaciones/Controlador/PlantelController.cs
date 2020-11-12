using SGCalificaciones.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCalificaciones.Controlador
{
    class PlantelController
    {
        BdCalificacionesEntities _db = new BdCalificacionesEntities();

        public List<Plantel_Educativo> Listar(string pBuscar)
        {
            return _db.Plantel_Educativo.Where(x => x.nombre.Contains(pBuscar)).ToList();
        }
        public bool Insertar(Data.Plantel_Educativo reg)
        {
            _db.Plantel_Educativo.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Plantel_Educativo reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Eliminar(int pParametro)
        {
            var reg = _db.Plantel_Educativo.Where(x => x.nro_carnet == pParametro).FirstOrDefault();
            _db.Plantel_Educativo.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        internal List<Plantel_Educativo> BuscarPorPK(int pCuenta)
        {
            return _db.Plantel_Educativo.Where(x => x.nro_carnet == pCuenta).ToList();
        }
        public bool Autenticar(int pUser, string pPass) //metodo autenticar con parametro Administrativo y contraseña respectivamente
        {
            try
            {
                //en una var "res" donde usamos de la base de datos usando la tabla Administrativo donde x sea usado para uso de datos en tabla BD
                var res = _db.Plantel_Educativo.Where(x => x.nro_carnet == pUser && x.contrasenia == pPass).SingleOrDefault(); //singleOrdefault mandará excepcion si existe mas de un Administrativo con lo mismos datos
                if (res != null) //si res es diferente de vacio
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal List<Plantel_Educativo> ControlSesion(string pUser, string pPass)
        {
            return _db.Plantel_Educativo.Where(x => x.usuario == pUser && x.contrasenia == pPass).ToList();
        }
        //public bool VerificarAdministrativoRepetido(string pCi) //metodo autenticar con parametro Administrativo y contraseña respectivamente
        //{ 
        //    try
        //    {
        //        //en una var "res" donde usamos de la base de datos usando la tabla Administrativo donde x sea usado para uso de datos en tabla BD
        //        var res = _db.Administrativo.Where(x => x.Ci == pCi).SingleOrDefault(); //singleOrdefault mandará excepcion si existe mas de un Administrativo con lo mismos datos
        //        if (res != null) //si res es diferente de vacio
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
    }
}
