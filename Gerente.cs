using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_rresponsibility
{
    public class Gerente : Verificador
    {
        public override void Procesar(Compra c)
        {
            if (c.Importe <= 1000)
            {
                Console.WriteLine(string.Format("Compra aprobada por el {0}", this.GetType().Name));
            }
            else
            {
                //IGUAL
                _siguiente.Procesar(c);
            }
        }
    }

}
