using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Garaje
    {
        private Coche coche;
        public string averia;
        public int numCochesAtendidos;

        public Garaje()
        {
            this.coche = null;
            this.averia = null;
            this.numCochesAtendidos = 0;
        }

        public bool aceptarCoche(Coche coche, string averia)
        {
            if (this.coche == null)
            {
                this.coche = coche;
                this.averia = averia;
                this.numCochesAtendidos++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void devolverCoche()
        {
            this.coche = null;
            this.averia = null;
        }
    }
}
