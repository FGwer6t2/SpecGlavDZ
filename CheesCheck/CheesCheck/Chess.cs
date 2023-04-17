using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesCheck
{
    public class Chess
    {
        // проверка хода для Короля
        public bool King(int x1, int y1, int x2, int y2)
        {
            if (Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1) return true;
            else return false;
        }

        // проверка хода для Королевы
        public bool Queen(int x1, int y1, int x2, int y2)
        {
            if ((x2 == x1 || y2 == y1) || (Math.Abs(x1 - x2) == Math.Abs(y1 - y2))) return true;
            else return false;
        }
        
        // проверка хода для Ладьи
        public bool Rook(int x1, int y1, int x2, int y2)
        {
            if (x2 == x1 || y2 == y1) return true;
            else return false;
        }

        // проверка хода для Слона
        public bool Bishop(int x1, int y1, int x2, int y2)
        {
            if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2)) return true;
            else return false;
        }

        // проверка хода для Коня
        public bool Knight(int x1, int y1, int x2, int y2)
        {
            if ((Math.Abs(x1-x2)==1 && Math.Abs(y1-y2)==2) ||(Math.Abs(x2-x1)==2 && Math.Abs(y2-y1)==1)) return true;
            else return false;

        }

        // проверка хода для Пешки
        public bool Pawn(int x1, int y1, int x2, int y2)
        {
            if (y1<=4) //Белая пешка
            {
                if (x1==x2 && y2-y1==1) return true;
                else return false;
            }
            else //Черная пешка
            {
                if (x1==x2 && y1-y2==1) return true;
                else return false;
            }
        }
    }
}
