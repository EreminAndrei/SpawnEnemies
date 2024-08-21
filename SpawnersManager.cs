using System.Collections;
using UnityEngine;

public class SpawnersManager : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawners = new Spawner[4];
    
    private float _delay = 2f;

    private void Start()
    {
        StartCoroutine(Count(_delay));
    }

    private IEnumerator Count (float delay)
    {
        var wait = new WaitForSeconds (delay);

        while (true)
        {
            yield return wait;
            int random = Random.Range (0, _spawners.Length);            
            _spawners[random].Spawn(); 
        }
    }
}
