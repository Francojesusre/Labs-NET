using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public abstract class Poligono
    {
        public int _base
        {
            get => default;
            set
            {
            }
        }

        public int _altura
        {
            get => default;
            set
            {
            }
        }

        public abstract float CalculaPerimetro();
        public abstract float CalculaSuperficie();

        class Rectangulo : Poligono
        {
            public override float CalcularPerimetro()
            { 
                return _base * 2 + _altura * 2; 
            }
            public override float CalcularSuperficie()
            { 
                return _base * _altura; 
            }
        }

        class Cuadrado:Rectangulo
        {
            public override float CalcularPerimetro()
            {
                return _base * 4;
            }
            public override float CalcularSuperficie()
            {
                return (_base * _altura) / 2;
            } 
        }
    }
}