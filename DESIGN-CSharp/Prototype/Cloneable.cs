using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    //冒險者履歷
    public class Resume : ICloneable
    {
        public string name { get; set; }

        public int level { get; set; }

        public string profession { get; set; }

        public AdventureExperience experience { get; set; }

        public Resume(string name, string profession, int level)
        {
            this.name = name;
            this.level = level;
            this.profession = profession;
            this.experience = new AdventureExperience();
        }

        //overloading 重載: C#中可以有多個構造函式
        public Resume(AdventureExperience experience) 
        {
            this.experience = (AdventureExperience)experience.Clone();
        }

        public void Display() 
        {
            Console.WriteLine($"冒險者：{name}-{profession} 等級:{level}");
            Console.WriteLine($"冒險經歷: {experience.date} {experience.location}");
            Console.WriteLine();
        }

        public object Clone()
        {
            Resume clone = new Resume(experience.Clone() as AdventureExperience);
            clone.name = this.name;
            clone.level = this.level;
            clone.profession = this.profession;
            return clone;
        }
    }

    //冒險者經歷
    public class AdventureExperience : ICloneable
    {
        public string date { get; set; }

        public string location { get; set; }

        public object Clone()
        {
            // 使用 MemberwiseClone 進行浅拷貝
            return this.MemberwiseClone();
        }
    }
}
