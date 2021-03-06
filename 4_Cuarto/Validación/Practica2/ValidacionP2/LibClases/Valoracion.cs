﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
     public class Valoracion
    {
        public Valoracion(int valor, string opinion, DateTime fecha)
        {
            this.valor = this.comprobarRangoValor(valor);
            this.opinion = opinion;
            if(fecha <= DateTime.Now)
            {
                this.fecha = fecha;
            }
            else
            {
                this.fecha = DateTime.Now;
            }
            
        }
        private int valor;
        public int Valor
        {
            get { return valor; }
            set
            {
                this.valor = this.comprobarRangoValor(value);
            }
        }


        private string opinion;
        public string Opinion
        {
            get { return opinion; }
            set { this.opinion = value; }
        }

        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { this.fecha = value; }
        }

        private int comprobarRangoValor(int value)
        {
            if (value >= 1 && value <= 4)
            {
                return value;
            }
            return 0;
        }

    }
}
