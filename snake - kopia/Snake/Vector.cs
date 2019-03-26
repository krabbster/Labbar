﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Vector
    {
        private int x;
        private int y;

        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}

