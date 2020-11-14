using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_rresponsibility
{
    public class Vendedor : Verificador
    {
        //
        public override void Procesar(Compra c)
        {
            if (c.Importe < 100)
            {
                Console.WriteLine(string.Format("Compra aprobada por el {0}", this.GetType().Name));
            }
            else
            {
                //pasara al sucesor si no cumplimos la condicion (Y
                _siguiente.Procesar(c);
            }
        }
    }

}
