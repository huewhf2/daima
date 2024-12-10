using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023享元模式_围棋棋子
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChessPiece black1 = ChessPieceFactory.GetChessPiece("黑色");
            black1.Place(1, 1);
            ChessPiece black2 = ChessPieceFactory.GetChessPiece("黑色");
            black2.Place(2, 2);
            ChessPiece white1 = ChessPieceFactory.GetChessPiece("白色");
            white1.Place(3, 3);
            ChessPiece whitel2 = ChessPieceFactory.GetChessPiece("白色");
            whitel2.Place(4, 4);
            // 验证是否共享了同一个对象
            Console.WriteLine($"black1 和 black2 是同一个对象吗？{object.ReferenceEquals(black1, black2)}");
            Console.WriteLine($"black1 和 white1 是同一个对象吗？{object.ReferenceEquals(black1, white1)}");
        }
    }
}
