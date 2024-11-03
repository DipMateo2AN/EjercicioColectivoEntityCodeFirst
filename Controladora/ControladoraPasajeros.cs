using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraPasajeros
    {
        private Context context = new Context();
        public bool AgregarPasajero(Pasajero nuevoPasajero)
        {
            var busqueda = context.Pasajeros.FirstOrDefault(p => p.PasajeroId == nuevoPasajero.PasajeroId);
            if (busqueda == null)
            {
                context.Pasajeros.Add(nuevoPasajero);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool EliminarPasajero(Pasajero nuevoPasajero)
        {
            var busqueda = context.Pasajeros.FirstOrDefault(p => p.PasajeroId == nuevoPasajero.PasajeroId);
            if (busqueda != null)
            {
                context.Pasajeros.Add(nuevoPasajero);
                context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
