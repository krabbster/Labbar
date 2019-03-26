using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Snake
{
    public abstract class Entity
    {
        public Point position;

        public Entity(Point position)
        {
            this.position = position;
        }

        public abstract void Draw(Graphics g, Brush brush);
    }
}
