using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class Subject
    {
        protected List<Adventure> list = new List<Adventure>();

        //想接收通知的觀察者
        public void add(Adventure observer) 
        {
            list.Add(observer);
        }

        //不想接收通知的觀察者
        public void remove(Adventure observer)
        {
            list.Remove(observer);
        }

        //發布任務
        public abstract void sendQuestions(String questions);
    }

    public class Association : Subject
    {
        public override void sendQuestions(String questions) 
        {
            foreach (var adventure in list)
            {
                adventure.getQuestions(questions);
            }
        }
    }
}
