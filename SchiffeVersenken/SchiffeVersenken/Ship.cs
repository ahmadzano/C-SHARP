namespace SchiffeVersenken.Data
{
    public enum Size { UBOOT = 2, ZERSTOERER = 3, KREUZER = 4, SCHLACHTSCHIFF = 5 }
    public enum Direction { RIGHT, DOWN, LEFT, UP }

    public class Ship
    {
        private Position _StartPos;
        private Size _Size;
        private Direction _Dir;

        public Ship(Size size)
        {
            _Size = size;
        }

        public Position StartPos
        {
            get
            {
                return _StartPos;
            }
            set { _StartPos = value; }
        }

        public int Size
        {
            get
            {
                return (int)_Size;
            }
        }

        public Direction Dir
        {
            get { return _Dir; }
            set { _Dir = value; }
        }

        public Position EndPos
        {
            get
            {
                switch (_Dir)
                {
                    case Direction.RIGHT:
                        return new Position(StartPos.X + Size - 1, StartPos.Y);
                    case Direction.DOWN:
                        return new Position(StartPos.X, StartPos.Y + Size - 1);
                    case Direction.LEFT:
                        return new Position(StartPos.X - Size + 1, StartPos.Y);
                    case Direction.UP:
                        return new Position(StartPos.X, StartPos.Y - Size + 1);
                }
                return new Position(0, 0);
            }
        }
    }
}
