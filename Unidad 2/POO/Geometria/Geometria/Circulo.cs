using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Circulo
    {
        private int m_radio;

        public int Radio
        {
            get => default;
            set
            {
            }
        }

        public double CalcularPerimetro()
        {
            return Math.PI * m_radio * 2;
        }

        public double CalcuarSuperficie()
        {
            return Math.PI * (m_radio * m_radio);
        }
    }
}
