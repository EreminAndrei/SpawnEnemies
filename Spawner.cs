using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;    
    [SerializeField] private Target _target;

    public void CreateEnemy()
    {
        var cube = Instantiate(_enemy, transform.position, Quaternion.identity);
        cube.GetTarget(_target);
    }   
}
