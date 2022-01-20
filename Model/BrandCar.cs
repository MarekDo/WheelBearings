using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelBearings.Model
{
    public class BrandCar
    {
        public int Id { get; set; }
        public string  Name { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{Name}";
            }
        }

    }
}
