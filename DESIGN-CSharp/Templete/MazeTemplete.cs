using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templete
{
    public abstract class MazeTemplete
    {
        public int difficulty { get; set; }

        public Adventurer adventurer;

        public bool isDoubleMaze = false; //hook: 決定是否有隱藏迷宮

        public Adventurer adventur(Adventurer adventurer) 
        {
            this.adventurer = adventurer;

            //確認冒險者等級
            if (!checkLevel(this.adventurer.level))
            {
                Console.WriteLine("Level is not enough ");
            }
            else 
            {
                Console.WriteLine(this.GetType().Name + " rise up the difficulty ");
                
                //產生迷宮
                createMaze();
                
                //闖迷宮
                start();
                
                //掛勾: 隱藏迷宮
                if (isDoubleMaze) 
                {
                    hiddenMaze();
                }

                //結束冒險
                showResult();
            }

            return this.adventurer;
        }

        private bool checkLevel(int level) 
        {
            if (level < this.difficulty) 
            {
                return false;
            }

            return true;
        }

        //迷宮內容
        public abstract void createMaze();

        //進入迷宮
        public abstract void start();

        //掛勾: 隱藏迷宮
        public void hiddenMaze() 
        {
            Console.WriteLine("Go to hidden maze ");
        }

        //冒險結束
        public Adventurer showResult() 
        {
            //等級增加
            this.adventurer.level = this.adventurer.level + 50 * this.difficulty;

            Console.WriteLine(this.GetType().Name + " Complete Maze difficulty: " + this.difficulty);

            return this.adventurer;
        }
    }

    //簡單迷宮
    public class EasyMaze : MazeTemplete 
    {
        public EasyMaze() 
        {
            base.difficulty = 1;
        }

        public override void createMaze()
        {
            Console.WriteLine("!!! Generated Easy Maze !!! " );
        }

        public override void start()
        {
            Console.WriteLine("-- start Easy Maze --");
        }
    }

    //困難迷宮
    public class DifficultMaze : MazeTemplete
    {
        public DifficultMaze()
        {
            base.isDoubleMaze = true; //困難模式有隱藏關卡
            base.difficulty = 50; //等級50才能進入迷宮
        }

        public override void createMaze()
        {
            Console.WriteLine("### Generated Difficult Maze ### ");
        }

        public override void start()
        {
            Console.WriteLine("-*- start Difficult Maze -*-");
        }
    }
}
