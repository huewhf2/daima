using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023享元模式_围棋棋子
{
    public class ChessPieceFactory
    {
        private static readonly Dictionary<string, ChessPiece> _pieceDic = new Dictionary<string, ChessPiece>();
        public static ChessPiece GetChessPiece(string color)
        {
            if (!_pieceDic.ContainsKey(color))
            {
                switch (color)
                {
                    case "黑色":
                        _pieceDic[color] = new BlackChessPiece();
                        break;
                    case "白色":
                        _pieceDic[color] = new WhiteChessPiece();
                        break;
                    default:
                        throw new ArgumentException("无效的颜色");
                }
            }
            return _pieceDic[color];
        }
    }
}
