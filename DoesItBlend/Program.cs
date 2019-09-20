using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBlendable> Items = new List<IBlendable>();
            
            Items.Add(new Strawberry());
            Items.Add(new Banana());
            Items.Add(new Mango());
            Items.Add(new IceCubes());
            Items.Add(new CellPhone());
            Items.Add(new Tomato());

            string result = "";
            foreach(IBlendable item in Items)
            {
                result +=  item.Blend();
                result += ", ";
            }


            Console.WriteLine(result);
        }
    }
}
