using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public GameObject _prefab;
    [SerializeField] private Vector3 _direction;
    
    private float _speed = 1.0f;

    private void FixedUpdate()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }

    public void Generate(Transform position, Vector3 direction)
    {
        _direction = direction;
        Instantiate(_prefab, position);
    }    
}
            
