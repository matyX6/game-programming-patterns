using UnityEngine;

namespace Assets.Command.Scripts
{
    public class InputHandler : MonoBehaviour
    {
        private MoveUp _buttonUp = new MoveUp();
        private MoveDown _buttonDown = new MoveDown();
        private MoveLeft _buttonLeft = new MoveLeft();
        private MoveRight _buttonRight = new MoveRight();
        private GameActor _gameActor = null;


        private void Start()
        {
            _gameActor = GetComponent<GameActor>();    
        }

        private ICommand HandleInput()
        {
            if (Input.GetKey(KeyCode.UpArrow)) {return _buttonUp; }
            if (Input.GetKey(KeyCode.DownArrow)) { return _buttonDown; }
            if (Input.GetKey(KeyCode.LeftArrow)) { return _buttonLeft; }
            if (Input.GetKey(KeyCode.RightArrow)) { return _buttonRight; }

            return null;
        }

        private void Update()
        {
            ICommand command = HandleInput();

            if (command != null)
            {
                command.Execute(GetComponent<GameActor>());
            }
        }

    }
}
