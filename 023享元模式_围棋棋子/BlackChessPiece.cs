using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023享元模式_围棋棋子
{
    public  class BlackChessPiece : ChessPiece
    {
        public override string Color => "黑色";
    }
    public class WhiteChessPiece : ChessPiece
    {
        public override string Color => "白色";
    }
}
