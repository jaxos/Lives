using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lives
{
    [Serializable]
    class Inventory
    {
        /* This is an inventory and in every  row there will be objects of different kind
         * e.g. food, 
         * 0. food
         * 1. 
         * 
         * 
         * 
         * 
         */


        private Object[,] list = new Object[5,3];
        
        public Inventory()
        {
            list[0,0] = new Apple();
        }
        //
        //
        //
        //

        

        public override string ToString()
        {
            String result = "";
            foreach (Object element in list)
            {
                if (element != null)
                {
                    result += "Object: " + element.ToString() + "\n";
                }
            }
            return result;
        }

    }
}
