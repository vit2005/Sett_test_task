using UnityEngine;

public class MoveCommandConverter : IConverter
{
    public ICommand Convert(CommandUI commandUI)
    {
        if (commandUI is MoveCommandUI moveCommandUI)
            return new MoveCommand(moveCommandUI.duration, moveCommandUI.targetPosition);
        else
        {
            Debug.Log("MoveCommandUI convertation error");
            return null;
        }
    }
}
