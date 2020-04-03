namespace Assets.Command.Scripts
{
    public interface ICommand
    {
        void Execute(GameActor actor);
    }

    public class MoveUp : ICommand
    {
        public void Execute(GameActor actor)
        {
            actor.MoveUp();
        }
    }

    public class MoveDown : ICommand
    {
        public void Execute(GameActor actor)
        {
            actor.MoveDown();
        }
    }

    public class MoveLeft : ICommand
    {
        public void Execute(GameActor actor)
        {
            actor.MoveLeft();
        }
    }

    public class MoveRight : ICommand
    {
        public void Execute(GameActor actor)
        {
            actor.MoveRight();
        }
    }
}
