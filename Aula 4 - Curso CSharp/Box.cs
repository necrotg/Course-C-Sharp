using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4___Curso_CSharp
{
    class Box
    {      
        private int Width { get; set; }
        private int Length { get; set; }
        private int Hight { get; set; }
        
        public int GetVolume()
        {
            return this.Length * this.Hight * this.Width;
        }
        public int GetFrontSurface()
        {
            return this.Length * this.Hight;
        }
        public Box()
        {
        }
        public Box(int width, int length, int hight)
        {
            this.Width = width;
            this.Length = length;
            this.Hight = hight;
        }

    }
}
