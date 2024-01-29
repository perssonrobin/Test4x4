using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4x4.Models
{
    class Table
    {
        public Table()
        {

        }
        public Table(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; protected set; }
        public int Height { get; protected set; }
    }
}
