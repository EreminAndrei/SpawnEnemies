using UnityEngine;

public class Enemy : MonoBehaviour
{    
    private Target _target;    
    private float _speed = 1.0f;

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _target.transform.position, _speed*Time.deltaTime);
    }

    public void GetTarget (Target target)
    {
        _target = target;        
    }    
}
            
