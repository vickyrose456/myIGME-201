using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlivieriQ10
    static class Program
    {
        public abstract class IceSkating
        {
            public string skates;
            public double speed;

            public abstract void Skating();
            public virtual void Speed(double speed)
            {
                this.speed = speed;
            }
        }

        public class Hockey : IceSkating, IHockey
        {
            public override void Skating()
            {
                Console.WriteLine("Hockey player skating");
            }
            public override void Speed(double speed)
            {
                Console.WriteLine("My hockey speed is: {0}", speed);
            }

            public void SlapShot()
            {
                Console.WriteLine("My slapshot is deadly!");
            }
        }

        public interface IHockey
        {
            void SlapShot();
        }

        public class FigureSkate : IceSkating, IFigure
        {
            public override void Skating()
            {
                Console.WriteLine("Firgure skater Skating");
            }
            public override void Speed(double speed)
            {
                Console.WriteLine("My Figure skating speed: {0}", speed);
            }
            public void TripleAxel()
            {
                Console.WriteLine("I did a triple axel!");
            }
        }
        public interface IFigure
        {
            void TripleAxel();
        }


    }

    public class Olivieri_UnitTestQ4
    {
        static void Main(string[] args)
        {

        }
    }

}
