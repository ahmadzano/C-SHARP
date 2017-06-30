using System;
using System.Collections.Generic;
using SchiffeVersenken.Data;

namespace SchiffeVersenken.Conntroller

{
    public class Conntroller
    {
        private Map _Map;
        private Random _Random;

        public Conntroller()
        {
            _Map = new Map(10, 10);
            _Random = new Random();
            while (!PopulateMap(_Map))
            {
                _Map = new Map(10, 10);
            }
        }

        public Map GetMap()
        {
            return _Map;
        }

        private bool PopulateMap(Map oMap)
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
