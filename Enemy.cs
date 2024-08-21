using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 1.0f;
    private Vector3 _wayPoint = Vector3.zero;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _wayPoint, _speed*Time.deltaTime);
    }
}
