using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Vector3 _direction;

    public void CreateEnemy()
    {
        var cube = Instantiate(_enemy, transform.position, Quaternion.identity);
        cube.GetDirection(_direction);
    }   
}
