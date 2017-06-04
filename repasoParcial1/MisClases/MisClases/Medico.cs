using System;

namespace MisClases
{
    public class Medico
    {
        
        DateTime _horarioEntrada;
        string _legajo;
        string _nombre;
        eEspecialidades _especialidad;

        public DateTime HorarioEntrada { get => _horarioEntrada; set => _horarioEntrada = value; }
        public string Legajo { get => _legajo; set => _legajo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        internal eEspecialidades Especialidad { get => _especialidad; set => _especialidad = value; }

        public Medico()
        {  }

        public Medico(DateTime hor, string leg, string nom, eEspecialidades esp)
        {
            this._horarioEntrada = hor;
            this._legajo = leg;
            this._nombre = nom;
            this._especialidad = esp;

        }

        public int OrdenarPorHorarioEntrada(Medico med1, Medico med2)
        {
            if (med1._horarioEntrada < med2._horarioEntrada)
                return -1;
            else
                return 1;
        }

        public int OrdenarPorLegajo(Medico med1, Medico med2)
        {
            return String.Compare(med1._legajo , med2._legajo);
        }

        public override string ToString()
        {
            return this._horarioEntrada + "&&" + this._legajo + "&&" + this._nombre + "&&" + this._especialidad;
        }

    }
}
