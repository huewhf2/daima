using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023享元模式_围棋棋子
{
    //抽象享元类
    public abstract class ChessPiece
    {
        public abstract string Color { get; }
        public void Place(int x, int y)
        {
            Console.WriteLine($"在位置 ({x}, {y}) 放置一个{Color}棋子。");
        }
    }
}
