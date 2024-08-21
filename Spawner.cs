using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;    

    public void Spawn()
    {
        Instantiate(_enemy,transform);
    }   
}
