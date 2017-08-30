using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaDeClases
{
    public class Pizza
    {
        string Name { get; set; }
        int Ingredients { get; set; }
        string Comments { get; set; }
        decimal Price { get; set; }


        

        public Pizza()
        {
            Name = string.Empty;
            Ingredients = 0;
            Comments = string.Empty;
            Price = Ingredients + 5;




        }
            
    }
}
