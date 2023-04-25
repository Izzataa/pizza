using PizzaMizza.Core.Enums;
using PizzaMizza.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Core.Models
{
   

        public class Pizza : BaseModel
        {
            private static int _id;
            public string Name { get; set; }
            public double Price { get; set; }
            public PizzaSize Size { get; set; }
            public string Ingridents { get; set; }


            public Pizza()
            {
                _id++;
                Id = _id;
            }

            public override string ToString()
            {
                return $"{Id} ,{Name} ,{Price} ,{CreatedDate} ,{UpdatedDate}";
            }
        }
    }
