using ROS.Persistence;
using System.Collections.Generic;

namespace ROS.Model
{
    public static class FacingsExtensions
    {
        private static readonly IReadOnlyDictionary<Facings, int> _deltaXTable =
            new Dictionary<Facings, int>()
            {
                [Facings.North] = 0,
                [Facings.East] = 1,
                [Facings.South] = 0,
                [Facings.West] = -1,
            };
        private static readonly IReadOnlyDictionary<Facings, int> _deltaYTable =
            new Dictionary<Facings, int>()
            {
                [Facings.North] = -1,
                [Facings.East] = 0,
                [Facings.South] = 1,
                [Facings.West] = 0,
            };
        private static readonly IReadOnlyDictionary<Facings, IReadOnlyDictionary<Moves, Facings>> _moveTable =
            new Dictionary<Facings, IReadOnlyDictionary<Moves, Facings>>()
            {
                [Facings.North] = new Dictionary<Moves, Facings>()
                {
                    [Moves.Forward] = Facings.North,
                    [Moves.Right] = Facings.East,
                    [Moves.Backward] = Facings.South,
                    [Moves.Left] = Facings.West,
                },
                [Facings.East] = new Dictionary<Moves, Facings>()
                {
                    [Moves.Forward] = Facings.East,
                    [Moves.Right] = Facings.South,
                    [Moves.Backward] = Facings.West,
                    [Moves.Left] = Facings.North,
                },
                [Facings.South] = new Dictionary<Moves, Facings>()
                {
                    [Moves.Forward] = Facings.South,
                    [Moves.Right] = Facings.West,
                    [Moves.Backward] = Facings.North,
                    [Moves.Left] = Facings.East,
                },
                [Facings.West] = new Dictionary<Moves, Facings>()
                {
                    [Moves.Forward] = Facings.West,
                    [Moves.Right] = Facings.North,
                    [Moves.Backward] = Facings.East,
                    [Moves.Left] = Facings.South,
                },
            };
        private static readonly IReadOnlyDictionary<Facings, IReadOnlyDictionary<Turns, Facings>> _turnTable =
            new Dictionary<Facings, IReadOnlyDictionary<Turns, Facings>>()
            {
                [Facings.North] = new Dictionary<Turns, Facings>()
                {
                    [Turns.Around] = Facings.South,
                    [Turns.Left] = Facings.West,
                    [Turns.Right] = Facings.East
                },
                [Facings.East] = new Dictionary<Turns, Facings>()
                {
                    [Turns.Around] = Facings.West,
                    [Turns.Left] = Facings.North,
                    [Turns.Right] = Facings.South
                },
                [Facings.South] = new Dictionary<Turns, Facings>()
                {
                    [Turns.Around] = Facings.North,
                    [Turns.Left] = Facings.East,
                    [Turns.Right] = Facings.West
                },
                [Facings.West] = new Dictionary<Turns, Facings>()
                {
                    [Turns.Around] = Facings.East,
                    [Turns.Left] = Facings.South,
                    [Turns.Right] = Facings.North
                },
            };
        internal static Facings MakeTurn(this Facings facing, Turns turn)
        {
            return _turnTable[facing][turn];
        }
        internal static Facings GetMoveFacing(this Facings facing, Moves move) 
        {
            return _moveTable[facing][move];
        }
        internal static int GetNextX(this Facings facing, int x, int y)
        {
            return x + _deltaXTable[facing];
        }
        internal static int GetNextY(this Facings facing, int x, int y)
        {
            return y + _deltaYTable[facing];
        }
    }
}
