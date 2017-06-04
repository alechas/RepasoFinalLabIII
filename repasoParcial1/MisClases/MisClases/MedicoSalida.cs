using System;
using System.Collections.Generic;
using System.Text;

namespace MisClases
{
    class MedicoSalida : Medico
    {
        Double _salario;
        DateTime _egreso;

        public double Salario
        {
            get
            {
                return calcularSalario();
            }
        }
        public DateTime Egreso { get => _egreso; set => _egreso = value; }
        
        public MedicoSalida():base()
        {
     
        }

        public MedicoSalida(DateTime hor, string leg, string nom, eEspecialidades esp, Double sal, DateTime egr):base(hor,leg,nom,esp)
        {
            this._salario = sal;
            this._egreso = egr;
        }

        private Double calcularSalario()
        {
            TimeSpan horas_tranajadas;

            horas_tranajadas = this._egreso.Subtract(this.HorarioEntrada.Date);

            return horas_tranajadas.Minutes * 15;
            
        }

    }
}
