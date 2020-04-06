using System.Collections.Generic;

namespace Assets.Command.Scripts
{
    public class MoveHistory : List<MoveUnitCommand>
    {
        public static MoveHistory Instance { get; } = new MoveHistory();


        private int pointer = 0;
        private bool enableClear = false;

        public new void Add(MoveUnitCommand item)
        {
            if (enableClear)
            {
                enableClear = false;
                Instance.RemoveRange(pointer + 1, Instance.Count - 1);
            }
            base.Add(item);
            pointer = Instance.Count - 1;
        }

        public MoveUnitCommand Undo()
        {
            if (pointer > 0) { pointer--; enableClear = (pointer + 1 < Instance.Count - 1); }
            return Instance[pointer];
        }

        public MoveUnitCommand Redo()
        {
            if (pointer < Instance.Count - 1) { pointer++; enableClear = (pointer + 1 < Instance.Count - 1); }
            return Instance[pointer];
        }
    }
}
