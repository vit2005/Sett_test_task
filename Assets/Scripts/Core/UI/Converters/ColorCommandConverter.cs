using UnityEngine;

public class ColorCommandConverter : IConverter
{
    public ICommand Convert(CommandUI commandUI)
    {
        if (commandUI is ColorCommandUI colorCommandUI)
            return new ColorCommand(colorCommandUI.targetColor);
        else
        {
            Debug.Log("ColorCommand convertation error");
            return null;
        }
    }
}
