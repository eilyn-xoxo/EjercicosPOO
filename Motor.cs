using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    
        public class Motor
        {
            public int litros_de_aceite;
        public int potencia;

            public Motor(int potencia)
            {
                this.potencia = potencia;
                this.litros_de_aceite = 0;
            }

            public int GetLitrosDeAceite()
            {
                return this.litros_de_aceite;
            }

            public void SetLitrosDeAceite(int litros_de_aceite)
            {
                this.litros_de_aceite = litros_de_aceite;
            }

            public int GetPotencia()
            {
                return this.potencia;
            }

            public void SetPotencia(int potencia)
            {
                this.potencia = potencia;
            }
        }

    }

