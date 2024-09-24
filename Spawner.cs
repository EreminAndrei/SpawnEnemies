using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnerPoint[] _spawnerPoints = new SpawnerPoint[4];
    
    private float _delay = 2f;

    private void Start()
    {
        StartCoroutine(SpawnEnemies(_delay));
    }

    private IEnumerator SpawnEnemies (float delay)
    {
        var wait = new WaitForSeconds (delay);

        while (true)
        {
            yield return wait;
            int random = Random.Range (0, _spawnerPoints.Length);            
            _spawnerPoints[random].CreateEnemy(); 
        }
    }
}
