using UnityEngine;

namespace Assets.Command.Scripts
{
    class InputHandler : MonoBehaviour
    {
        [SerializeField] float _offsetValue = 1f;

        private void Update()
        {
            MoveUnitCommand command = HandleInput();

            if (command != null)
            {
                command.Execute();
            }
        }

        private MoveUnitCommand HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                float destY = transform.position.y + _offsetValue;
                return new MoveUnitCommand(transform, transform.position.x, destY);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                float destY = transform.position.y - _offsetValue;
                return new MoveUnitCommand(transform, transform.position.x, destY);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                float destX = transform.position.x - _offsetValue;
                return new MoveUnitCommand(transform, destX, transform.position.y);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                float destX = transform.position.x + _offsetValue;
                return new MoveUnitCommand(transform, destX, transform.position.y);
            }

            return null;
        }
    }
}
