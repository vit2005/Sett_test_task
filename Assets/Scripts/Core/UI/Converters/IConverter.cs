using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IConverter 
{
    ICommand Convert(CommandUI commandUI);
}
