using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchiffeVersenken.Data
{
    public enum Field { NONE = 0, SHIP = 1, HIT = -1, MISS = -2 }

    public class GameMap
    {
        //private Random _Rand;
        private int[,] _Map;
        private int[,] _BlockMap;


        public int this[int y, int x]
        {
            get
            {
                return _Map[y, x];
            }
            set
            {
                _Map[y, x] = value;
            }
        }

        public int Height
        {
            get { return _Map.GetLength(0); }
        }

        public int Length
        {
            get { return _Map.GetLength(1); }
        }


        public GameMap(int height, int width)
        {
            _Map = new int[height, width];
            _BlockMap = new int[height, width];
            //_Rand = new Random();

        }

        public void AddShip(Ship oShip)
        {
            GenerateBlockMap(oShip);
            Position oStart = oShip.StartPos;
            Position oEnd = oShip.EndPos;
            if (oShip.Dir == Direction.LEFT || oShip.Dir == Direction.UP)
            {
                oStart = oShip.EndPos;
                oEnd = oShip.StartPos;
            }
            for (int y = oStart.Y; y <= oEnd.Y; y++)
            {
                for (int x = oStart.X; x <= oEnd.X; x++)
                {
                    _Map[y, x] = 1;
                }
            }

        }

        private bool IsInbounds(Position oPos)
        {
            return IsInbounds(oPos.X, oPos.Y);
        }

        private bool IsInbounds(int x, int y)
        {
            if (x < 0 || x >= this.Length || y < 0 || y >= this.Height)
                return false;
            return true;
        }

        private void GenerateBlockMap(Ship oShip)
        {
            Position oStart, oEnd;
            if (oShip.Dir == Direction.LEFT || oShip.Dir == Direction.UP)
            {
                oStart = GetBlockStart(oShip.EndPos);
                oEnd = GetBlockEnd(oShip.StartPos);
            }
            else
            {
                oStart = GetBlockStart(oShip.StartPos);
                oEnd = GetBlockEnd(oShip.EndPos);
            }

            for (int y = oStart.Y; y <= oEnd.Y; y++)
            {
                for (int x = oStart.X; x <= oEnd.X; x++)
                {
                    _BlockMap[y, x] = 1;
                }
            }

        }

        public bool IsEmpty(Position oPos)
        {
            return _BlockMap[oPos.Y, oPos.X] == (int)Field.NONE;
        }


        public bool IsShipPlaceable(Ship oShip)
        {
            if (!IsEmpty(oShip.StartPos))
                return false;
            if (!CheckDirection(oShip))
                return false;
            return true;
        }

        private bool CheckDirection(Ship oShip)
        {
            Position oTempPos = oShip.StartPos;

            for (int i = 0; i < oShip.Size; i++)
            {
                oTempPos = oTempPos.Add(Position.ConvertDirection(oShip.Dir));
                if (!(IsInbounds(oTempPos) && IsEmpty(oTempPos)))
                {
                    return false;
                }
            }
            return true;
        }

        #region debugPrints
        public void Print()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Length; i++)
            {
                for (int j = 0; j < this.Height; j++)
                {
                    sb.Append("[ " + _Map[i, j] + " ]");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }

        public void PrintBlockMap()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Length; i++)
            {
                for (int j = 0; j < this.Height; j++)
                {
                    sb.Append("[ " + _BlockMap[i, j] + " ]");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }

        #endregion


        private Position GetBlockStart(Position oPos)
        {
            int x = oPos.X == 0 ? oPos.X : oPos.X - 1;
            int y = oPos.Y == 0 ? oPos.Y : oPos.Y - 1;
            return new Position(x, y);
        }

        private Position GetBlockEnd(Position oPos)
        {
            int x = oPos.X == Length - 1 ? oPos.X : oPos.X + 1;
            int y = oPos.Y == Height - 1 ? oPos.Y : oPos.Y + 1;
            return new Position(x, y);
        }

        public List<List<int>> ToList()
        {
            List<List<int>> oMapList = new List<List<int>>();
            for (int y = 0; y < Height; y++)
            {
                List<int> oInnerList = new List<int>();
                for (int x = 0; x < Length; x++)
                {
                    oInnerList.Add(_Map[y, x]);
                }
                oMapList.Add(oInnerList);
            }
            return oMapList;
        }
    }
}
