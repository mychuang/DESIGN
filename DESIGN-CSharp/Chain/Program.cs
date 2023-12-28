using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager pm = new CommonManager("PM");

            Manager gl = new MajorDemo("GL");

            Manager gm = new GeneralManager("GM");

            //設定上級
            pm.setSuperior(gl);
            gl.setSuperior(gm);

            //請假
            ApplyRequest request = new ApplyRequest();
            request.requestType = "break";
            request.requestContent = "Miller break";
            request.requestCount = 2;
            pm.apply(request);

            request.requestContent = "Miller break";
            request.requestCount = 4;
            pm.apply(request);

            request.requestContent = "Miller break";
            request.requestCount = 30;
            pm.apply(request);

            Console.ReadKey();
        }
    }
}
