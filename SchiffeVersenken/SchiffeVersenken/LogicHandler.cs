using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SchiffeVersenken.Data;

namespace SchiffeVersenken.Logic
{
    public class LogicHandler
    {
        private GameMap _Map;
        private Random _Random;

        public LogicHandler()
        {
            _Map = new GameMap(10, 10);
            _Random = new Random();
            while (!PopulateMap(_Map))
            {
                _Map = new GameMap(10, 10);
            }
        }

        public GameMap GetMap()
        {
            return _Map;
        }

        private bool PopulateMap(GameMap oMap)
        {
            int counter = 0;
            List<Ship> oShipList = GenerateShips();
            foreach (Ship oShip in oShipList)
            {
                oShip.StartPos = GetRandomLocation();
                oShip.Dir = (Direction)_Random.Next(4);
                while (!_Map.IsShipPlaceable(oShip))
                {
                    oShip.StartPos = GetRandomLocation();
                    oShip.Dir = (Direction)_Random.Next(4);
                    if (counter >= 5000)
                        return false;
                    else
                        counter++;
                }
                _Map.AddShip(oShip);
            }
            return true;
        }

        private List<Ship> GenerateShips()
        {
            List<Ship> oShipList = new List<Ship>() {
                new Ship(Size.SCHLACHTSCHIFF),
                new Ship(Size.KREUZER),
                new Ship(Size.KREUZER),
                new Ship(Size.ZERSTOERER),
                new Ship(Size.ZERSTOERER),
                new Ship(Size.ZERSTOERER),
                new Ship(Size.UBOOT),
                new Ship(Size.UBOOT),
                new Ship(Size.UBOOT),
                new Ship(Size.UBOOT)};
            return oShipList;
        }

        private Position GetRandomLocation()
        {
            int x = _Random.Next(0, _Map.Length);
            int y = _Random.Next(0, _Map.Height);
            return new Position(x, y);
        }
    }
}
