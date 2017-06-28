using System;

namespace SchiffeVersenken.Data
{

    public class Position
    {
        public static Position LEFT = new Position(-1, 0);
        public static Position RIGHT = new Position(1, 0);
        public static Position UP = new Position(0, -1);
        public static Position DOWN = new Position(0, 1);

        public static Position UPLEFT = new Position(-1, -1);
        public static Position UPRIGHT = new Position(1, -1);
        public static Position DOWNLEFT = new Position(1, -1);
        public static Position DOWNRIGHT = new Position(1, 1);

        private int _x, _y;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Position(int xPos, int yPos)
        {
            _x = xPos;
            _y = yPos;
        }

        public Position()
        {
            X = 0;
            Y = 0;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Position))
                return false;
            Position oPos = obj as Position;
            return oPos.X == this._x && oPos.Y == this._y;
        }

        public Position Add(Position oPos)
        {
            return new Position(this._x + oPos.X, this._y + oPos.Y);
        }

        public static Position ConvertDirection(Direction oDir)
        {
            switch (oDir)
            {
                case Direction.DOWN:
                    return DOWN;
                case Direction.UP:
                    return UP;
                case Direction.LEFT:
                    return LEFT;
                case Direction.RIGHT:
                    return RIGHT;
                default:
                    return new Position(0, 0);
            }
        }
    }
}
