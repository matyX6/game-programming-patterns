using UnityEngine;

namespace Assets.Command.Scripts
{
    public class GameActor : MonoBehaviour
    {
        [SerializeField] float _speed = 1f;

        public void MoveUp()
        {
            Move(Vector3.up);
            Debug.Log("MoveUp");
        }

        public void MoveDown()
        {
            Move(Vector3.down);
            Debug.Log("MoveDown");
        }

        public void MoveLeft()
        {
            Move(Vector3.left);
            Debug.Log("MoveLeft");
        }

        public void MoveRight()
        {
            Move(Vector3.right);
            Debug.Log("MoveRight");
        }

        private void Move(Vector3 axis)
        {
            transform.Translate(axis * _speed * Time.deltaTime);
        }
    }
}
