using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Colectivo
    {
        public int ColectivoId {  get; set; }
        public string Patente {  get; set; }
        public string Nombre {  get; set; }
        public int CantidadAsientos {  get; set; }

        public List<Pasajero> Pasajeros;

        public Colectivo()
        {
            Pasajeros = new List<Pasajero>();
        }

        public bool AgregarPasajero(Pasajero nuevoPasajero)
        {
            var pDuplicado = Pasajeros.FirstOrDefault(x => x.PasajeroId == nuevoPasajero.PasajeroId);
            if (pDuplicado == null)
            {
                Pasajeros.Add(nuevoPasajero);
                return true;
            }
            return false;
        }

        public bool EliminarPasajero(Pasajero pasajeroAEliminar)
        {
            var pDuplicado = Pasajeros.FirstOrDefault(x => x.PasajeroId == pasajeroAEliminar.PasajeroId);
            if (pDuplicado != null)
            {
                Pasajeros.Remove(pasajeroAEliminar);
                return true;
            }
            return false;
        }
    }
}
