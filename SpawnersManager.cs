using System.Collections;
using UnityEngine;

public class SpawnersManager : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawners = new Spawner[4];
    
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
            int random = Random.Range (0, _spawners.Length);            
            _spawners[random].CreateEnemy(); 
        }
    }
}
