using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo
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

        public int _lado2
        {
            get => default;
            set
            {
            }
        }

        public int _lado3
        {
            get => default;
            set
            {
            }
        }

        public float CalculaSuperficie()
        {
            return ((_base * _altura) / 2);
        }

        public float CalculaPerimetro()
        {
            return _base + _lado2 + _lado3;
        }
    }
}