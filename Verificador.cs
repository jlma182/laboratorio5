using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_rresponsibility
{
    public abstract class Verificador
    {
        protected Verificador _siguiente;

        public void AgregarSiguiente(Verificador aprobador)
        {
            _siguiente = aprobador;
        }

        public abstract void Procesar(Compra c);
    }

}
