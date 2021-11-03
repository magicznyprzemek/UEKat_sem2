using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_6_z4
{
    class Prostopadloscian : Szescian
    {

        double x, y, z;
        public Prostopadloscian(double x, double y, double z, string nazwa="*prostopadłościan*") : base(x)
        {
            this.x = x;
            nazwa = "prostopadłościan";
            this.y = y;
            this.z = z;
        }
        public override double obj()
        {
            return (krawedz*y)*z;
        }
        public override string ToString()
        {
            return $"Nazwa: {nazwa} | Krawędzie: {x}x{y}x{z} | Objętośc: {obj()}";
        }
    }
}
