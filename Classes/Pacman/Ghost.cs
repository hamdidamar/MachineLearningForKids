using Entity_Layer.Abstract_Classes;
using Entity_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class Ghost : MovingObject
    {
        public Ghost()
        {
            objectType = ImageObjectType.GHOST;
            movementSpeed = 5;
            currentDirection = Directions.NoDirection;
        }
    }
}
