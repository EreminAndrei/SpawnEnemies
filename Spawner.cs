using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Vector3 _direction;

    public void Spawn()
    {
        _enemy.Generate(transform, _direction);
    }   
}
