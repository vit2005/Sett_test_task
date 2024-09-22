using UnityEngine;

public interface IGameObjectCommand : ICommand
{
    void SetGameObject(GameObject gameObject);
}