using System;
using System.Collections.Generic;
using System.Text;

namespace prjSecondApplication
{
    //virtual keyword is used for overriding the implementation details
    class UGC
    {
        string[] rules = { "Dress code", "Identity Card" };

        public virtual void RulesMethod()
        {
            foreach(var r in rules)
            {
                Console.WriteLine("Rule:{0}", r);
            }
        }
    }

    class MIT : UGC
    {
        string mitRule = "No Mobile";
        //override is being used which will override the base class method implementation
        public override void RulesMethod()
        {
            base.RulesMethod(); //you can also comment this if you dont want to include ugc rules in mit rules
            Console.WriteLine("MIT rules :{0}", mitRule);
        }
    }

    class AnnaUniversity : UGC
    {
        string annaRule = "Only formal Dress";
        //new is being used which will allocate the memory for this method and wont override the base class method implementation
        public new void RulesMethod()
        {
            base.RulesMethod();
            Console.WriteLine("AnnaUniversity Rules :{0}", annaRule);
        }
    }
    
    class VirtualEg
    {
        static  void Main()
        {
            UGC uGC = new UGC();
            Console.WriteLine("UGC Rules");
            uGC.RulesMethod();
            Console.WriteLine("MIT Rules");
            MIT mitobj = new MIT();
            mitobj.RulesMethod();
            Console.WriteLine("Anna Rules");
            AnnaUniversity au = new AnnaUniversity();
            au.RulesMethod();
        }
    }
}
