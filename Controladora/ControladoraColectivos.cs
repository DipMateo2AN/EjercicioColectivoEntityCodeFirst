using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Controladora
{
    public class ControladoraColectivos
    {
        private Context context = new Context();
        public bool AgregarColectivo(Colectivo nuevoColectivo)
        {
            var busqueda = context.Colectivos.FirstOrDefault(p => p.ColectivoId == nuevoColectivo.ColectivoId);
            if (busqueda == null)
            {
                context.Colectivos.Add(nuevoColectivo);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool EliminarColectivo(Colectivo colectivo)
        {
            var busqueda = context.Colectivos.FirstOrDefault(p => p.ColectivoId == colectivo.ColectivoId);
            if (busqueda != null)
            {
                context.Colectivos.Remove(colectivo);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Colectivo> ListarColectivos()
        {
            return context.Colectivos.ToList();
        }
    }
}
