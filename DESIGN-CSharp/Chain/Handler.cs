using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    public abstract class Manager
    {
        public string name { get; set; }

        protected Manager superior; //上一級管理者

        public Manager(string name) 
        {
            this.name = name;
        }

        //設定上一級管理者
        public void setSuperior(Manager superior) 
        {
            this.superior = superior;
        }

        //提出申請
        public abstract void apply(ApplyRequest request);
    }

    //經理
    public class CommonManager : Manager 
    {
        public CommonManager(string name) : base(name) { }

        public override void apply(ApplyRequest request)
        {
            //2天以下批准
            if (request.requestType.Equals("break") && request.requestCount <= 2)
            {
                Console.WriteLine(request.requestType + " : " + request.requestContent);
                Console.WriteLine(request.requestCount + " is applied by " + this.name);
            }
            else 
            {
                if (this.superior != null) 
                {
                    this.superior.apply(request);
                }
            }
        }
    }

    //總監
    public class MajorDemo : Manager
    {
        public MajorDemo(string name) : base(name) { }

        public override void apply(ApplyRequest request)
        {
            //5天以下批准
            if (request.requestType.Equals("break") && request.requestCount <= 5)
            {
                Console.WriteLine(request.requestType + " : " + request.requestContent);
                Console.WriteLine(request.requestCount + " is applied by " + this.name);
            }
            else
            {
                if (this.superior != null)
                {
                    this.superior.apply(request);
                }
            }
        }
    }

    //總經理
    public class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name) { }

        public override void apply(ApplyRequest request)
        {
            if (request.requestType.Equals("break"))
            {
                Console.WriteLine(request.requestType + " : " + request.requestContent);
                Console.WriteLine(request.requestCount + " is applied by " + this.name);
            }
            else
            {
                Console.WriteLine(" Error Message");
            }
        }
    }
}
