using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinetic_Energy_Calculator
{
    public class KineticEnergyCalculator
    {
        
            private double mass;
            private double velocity;

            public KineticEnergyCalculator(double mass, double velocity)
            {
                this.mass = mass;
                this.velocity = velocity;
            }

            public double CalculateKineticEnergy()
            {
                return 0.5 * mass * Math.Pow(velocity, 2);
            }
        
    }
}
