using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templete
{
    public abstract class Adventurer
    {
        public int level { get; set; }
        public string type { get; set; }
    }

    public class GundamJustice : Adventurer 
    {
        public GundamJustice() 
        {
            base.type = "Gundam-Justice";
            base.level = 100;
        }
    }

    public class Sabar : Adventurer
    {
        public Sabar()
        {
            base.type = "Sabar";
            base.level = 10;
        }
    }
}
