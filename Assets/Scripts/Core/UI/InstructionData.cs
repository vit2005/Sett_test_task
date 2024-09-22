using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InstructionData", menuName = "ScriptableObjects/InstructionData")]
public class InstructionData : ScriptableObject
{
    [SerializeReference] public List<CommandUI> commands = new List<CommandUI>();
}