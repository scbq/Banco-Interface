using ConInterfaces.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConInterfaces.Clases
{
    public class Factura : Ifecha, Indesplegable
    {
        //Atributos
        private int folio;
        private string cliente;
        private double total;
        private DateTime dfecha;

        //Propiedades
        public int Folio
        {
            get { return folio; }
            set { folio = value; }
        }
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public DateTime Fecha
        {
            get { return dfecha; }
            set { dfecha = value; }
        }

        //Lista
        public List<Factura> fact;

        public string fechaConLetra()
        {
            string strMes = " ";
            switch (this.Fecha.Month)
            {
                case 1: strMes = "Enero";
                    break;
                case 2:
                    strMes = "Febrero";
                    break;
                case 3:
                    strMes = "Marzo";
                    break;
                case 4:
                    strMes = "Abril";
                    break;
                case 5:
                    strMes = "Mayo";
                    break;
                case 6:
                    strMes = "Junio";
                    break;
                case 7:
                    strMes = "Julio";
                    break;
                case 8:
                    strMes = "Agosto";
                    break;
                case 9:
                    strMes = "Septiembre";
                    break;
                case 10:
                    strMes = "Octubre";
                    break;
                case 11:
                    strMes = "Noviembre";
                    break;
                case 12:
                    strMes = "Diciembre";
                    break;
            }
            return (this.Fecha.Day.ToString() + "/" + strMes + "/" + this.Fecha.Year.ToString());

        }
        public string MostrarDatos()
        {
            StringBuilder sb= new StringBuilder();
            sb.Append("\n Datos de las facturas");
            sb.Append("\nFolio: " + folio);
            sb.Append("\nCiente: " + cliente);
            sb.Append("\nTotal: " + total.ToString("c"));
            sb.Append("\nFecha: " + fechaConLetra());
            return sb.ToString();
        }
        public override string ToString()
        {
            return ("Factura: " + folio);
        }

    }
}

