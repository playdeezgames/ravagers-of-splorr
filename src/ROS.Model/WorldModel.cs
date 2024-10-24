﻿using ROS.Persistence;

namespace ROS.Model
{
    public class WorldModel : IWorldModel
    {
        private readonly IWorld _world;
        private int _x = 0;
        private int _y = 0;
        private Facings _facing = Facings.North;

        protected WorldModel(IWorld world) 
        {
            _world = world;
        }

        public int X => _x;

        public int Y => _y;

        public Facings Facing => _facing;

        public static WorldModel Create()
        {
            return new WorldModel(World.Create());
        }

        public void Move(Moves move)
        {
            var moveFacing = _facing.GetMoveFacing(move);
            int nextX = _facing.GetNextX(_x, _y);
            int nextY = _facing.GetNextY(_x, _y);
            _x = nextX;
            _y = nextY;
        }

        public void Turn(Turns turn)
        {
            _facing = _facing.MakeTurn(turn);
        }
    }
}