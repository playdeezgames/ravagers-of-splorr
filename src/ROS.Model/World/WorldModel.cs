﻿using ROS.Model.Enums;
using ROS.Model.Extensions;
using ROS.Model.World;
using ROS.Persistence;

namespace ROS.Model
{
    public class WorldModel : IWorldModel
    {
        private readonly IWorld _world;

        protected WorldModel(IWorld world) 
        {
            _world = world;
        }

        public int X => _world.X;

        public int Y => _world.Y;

        public Facings Facing => _world.Facing;

        public static WorldModel Create()
        {
            return new WorldModel(ROS.Persistence.World.Create());
        }

        public void Move(Moves move)
        {
            var moveFacing = _world.Facing.GetMoveFacing(move);
            int nextX = _world.Facing.GetNextX(_world.X, _world.Y);
            int nextY = _world.Facing.GetNextY(_world.X, _world.Y);
            _world.X = nextX;
            _world.Y = nextY;
        }

        public void Turn(Turns turn)
        {
            _world.Facing = _world.Facing.MakeTurn(turn);
        }
    }
}