using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templete
{
    class Program
    {
        static void Main(string[] args)
        {
            Adventurer sabar = new Sabar(); //等級10的劍士
            Adventurer justice = new GundamJustice(); //等級100的正義鋼彈

            MazeTemplete easyMaze = new EasyMaze(); //簡單迷宮
            MazeTemplete hardMaze = new DifficultMaze(); //複雜迷宮

            // 劍士進入迷宮
            sabar = hardMaze.adventur(sabar);
            sabar = easyMaze.adventur(sabar);
            Console.WriteLine("sabar level: " + sabar.level);

            Console.WriteLine("");
            Console.WriteLine("==========================");
            Console.WriteLine("");

            // 劍士再次挑戰迷宮
            sabar = hardMaze.adventur(sabar);
            Console.WriteLine("sabar level: " + sabar.level);

            Console.WriteLine("");
            Console.WriteLine("==========================");
            Console.WriteLine("");

            // 正義鋼彈進入迷宮
            justice = hardMaze.adventur(justice);
            Console.WriteLine("sabar level: " + justice.level);

            Console.ReadKey();
        }
    }
}
