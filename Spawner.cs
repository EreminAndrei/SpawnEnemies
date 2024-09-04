using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Vector3 _direction;

    public void CreateEnemy()
    {
        _enemy.Init(transform, _direction);
    }   
}
