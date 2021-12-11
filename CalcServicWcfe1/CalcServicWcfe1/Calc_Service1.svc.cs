using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalcServicWcfe1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calc_Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calc_Service1.svc or Calc_Service1.svc.cs at the Solution Explorer and start debugging.
    public class Calc_Service1 : ICalc_Service1
    {
        

        int ICalc_Service1.add(int a, int b)
        {
            return a + b;
        }

        int ICalc_Service1.div(int a, int b)
        {
            return a / b;
        }

        int ICalc_Service1.mul(int a, int b)
        {
            return a * b;
        }

        int ICalc_Service1.sub(int a, int b)
        {
            return a - b;
        }


    }
}
