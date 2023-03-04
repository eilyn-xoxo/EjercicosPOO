using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Coche
    {
        public Motor motor;
        public string marca;
        public string matricula;
        public string modelo;
        public string LitrosAceite;
        public double precioAcumuladoAverias;

        public Coche(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.motor = new Motor(0);
            this.precioAcumuladoAverias = 0.0;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public string GetModelo()
        {
            return this.modelo;
        }

        public Motor GetMotor()
        {
            return this.motor;
        }
     

        public double GetPrecioAcumuladoAverias()
        {
            return this.precioAcumuladoAverias;
        }

        public void acumularAveria(double importe)
        {
            this.precioAcumuladoAverias += importe;
        }

        internal void AgregarAceite(int v)
        {
            throw new NotImplementedException();
        }
    }

}
