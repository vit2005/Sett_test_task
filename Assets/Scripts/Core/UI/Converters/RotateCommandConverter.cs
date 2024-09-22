using UnityEngine;

public class RotateCommandConverter : IConverter
{
    public ICommand Convert(CommandUI commandUI)
    {
        if (commandUI is RotateCommandUI rotateCommandUI) 
            return new RotateCommand(rotateCommandUI.duration, rotateCommandUI.targetRotation);
        else
        {
            Debug.Log("Convertation error");
            return null;
        }    
    }
}
