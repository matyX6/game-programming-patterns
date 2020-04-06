using UnityEngine;

namespace Assets.Command.Scripts
{
    class InputHandler : MonoBehaviour
    {
        [SerializeField] float _offsetValue = 1f;


        private void Start()
        {
            MoveUnitCommand moveUnitCommand = new MoveUnitCommand(
                transform, 
                transform.position.x, 
                transform.position.y);

            MoveHistory.Instance.Add(moveUnitCommand);
        }

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
                MoveUnitCommand moveUnitCommand = new MoveUnitCommand(transform, transform.position.x, destY);
                MoveHistory.Instance.Add(moveUnitCommand);
                return moveUnitCommand;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                float destY = transform.position.y - _offsetValue;
                MoveUnitCommand moveUnitCommand = new MoveUnitCommand(transform, transform.position.x, destY);
                MoveHistory.Instance.Add(moveUnitCommand);
                return moveUnitCommand;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                float destX = transform.position.x - _offsetValue;
                MoveUnitCommand moveUnitCommand = new MoveUnitCommand(transform, destX, transform.position.y);
                MoveHistory.Instance.Add(moveUnitCommand);
                return moveUnitCommand;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                float destX = transform.position.x + _offsetValue;
                MoveUnitCommand moveUnitCommand = new MoveUnitCommand(transform, destX, transform.position.y);
                MoveHistory.Instance.Add(moveUnitCommand);
                return moveUnitCommand;
            }

            if (Input.GetKeyDown(KeyCode.U))
            {
                return MoveHistory.Instance.Undo();
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                return MoveHistory.Instance.Redo();
            }

            return null;
        }
    }
}
