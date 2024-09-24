using UnityEngine;

public class SpawnerPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;    
    [SerializeField] private Target _target;

    public void CreateEnemy()
    {
        Enemy enemy = Instantiate(_enemy, transform.position, Quaternion.identity);
        enemy.DefineTarget(_target);
    }   
}
