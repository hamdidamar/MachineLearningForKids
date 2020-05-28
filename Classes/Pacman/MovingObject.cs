using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Abstract_Classes
{
    public class MovingObject : ImageObject
    {
        public double movementSpeed;
        public Directions currentDirection;
    }
}
