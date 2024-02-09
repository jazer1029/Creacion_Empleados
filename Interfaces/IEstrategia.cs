using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_Empleados.Interfaces
{
    public interface IEstrategia
    {
        void GuardarListaGerente();
        void GuardarListaAdministrador();
        void GuardarListaOperador();
        void CargarListas();
    }
}
