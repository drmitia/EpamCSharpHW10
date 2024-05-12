using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamHW10
{
    internal class Automobile
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public Automobile(string madelName, int modelMaxSpeed)
        {
            Name = madelName;
            MaxSpeed = modelMaxSpeed;
        }
        public Automobile FindFastestcar(List<Automobile> array)
        {
            Automobile max = array[0];
            foreach (Automobile car in array)
            {
                if (car.MaxSpeed >= max.MaxSpeed)
                {
                    max = car;
                }
            }
            return max;
        }
    }
}
