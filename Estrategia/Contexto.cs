using Creacion_Empleados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_Empleados.Estrategia
{
    internal class Contexto
    {

        private IEstrategia Estrategia;

        public Contexto(IEstrategia Empleado)
        {
            this.Estrategia = Empleado;
        }

        public void EjecutarGerente()
        {
            this.Estrategia.GuardarListaGerente();
        }
        public void EjecutarAdministrador()
        {
            this.Estrategia.GuardarListaAdministrador();
        }
        public void EjecutarOperador()
        {
            this.Estrategia.GuardarListaOperador();
        }
        public void Leer()
        {
            this.Estrategia.CargarListas();
        }

    }
}
