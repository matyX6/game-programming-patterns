using UnityEngine;

namespace Assets.Command.Scripts
{
    public class MoveUnitCommand
    {
        private Transform _unit;
        private float _x;
        private float _y;

        public MoveUnitCommand(Transform unit, float x, float y)
        {
            _unit = unit;
            _x = x;
            _y = y;
        }

        public void Execute()
        {
            _unit.position = new Vector3(_x, _y);
        }
    }
}


