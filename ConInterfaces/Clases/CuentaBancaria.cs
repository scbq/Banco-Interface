using ConInterfaces.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConInterfaces.Clases
{
    public class CuentaBancaria:Ifecha,Indesplegable
    {
        //Atributos
        private int numero;
        private double saldo;
        private DateTime fechaApertura;

        //Propiedades
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public DateTime Fecha
        {
            get { return fechaApertura; }
            set { fechaApertura = value;}
        }

        //Lista
        public List<CuentaBancaria> cta;

        public string fechaConLetra()
        {
            return this.Fecha.ToLongDateString();
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nCuentas Bancarias");
            sb.Append("\nNumero: " + numero);
            sb.Append("\nSaldo: " + saldo);
            sb.Append("\nFecha de Apertura: " + fechaConLetra());
            return sb.ToString();
        }
        public override string ToString()
        {
            return ("Cuenta Bancaria: " + numero);
        }
    }
}
