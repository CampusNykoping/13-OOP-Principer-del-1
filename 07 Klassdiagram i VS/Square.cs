using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_Klassdiagram_i_VS
{
    public class Square : Shape, ISurfaceCalculatable
    {
        public int Size
        {
            get => default;
            set
            {
            }
        }

        public float CalculateSurface()
        {
            throw new NotImplementedException();
        }
    }
}