using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Ref_Out_Params_In
{
    internal class Bottle
    {
        public string type;
        public bool isRecycled;

        public Bottle(string type)
        {
            this.type = type;
        }
        public void Recycle(ref int howMany, int max)
        {
            if(howMany < max && (type == "plastik" || type == "zhuhit"))
            {
                howMany++;
                isRecycled = true;
            }
        }

        public override string ToString()
        {
            return $"type: {type}. is recycled: {isRecycled}.";
        }
    }
}
