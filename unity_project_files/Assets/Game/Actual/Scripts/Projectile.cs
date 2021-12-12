using UnityEngine;

public class Projectile : MonoBehaviour
{

    private Transform target;
    private Vector3 playerPosition;
    public float speed = 30f;
    

    public void Seek(Transform _target, Vector3 _playerPosition)
    {
        target = _target;
        playerPosition = _playerPosition;
    }
    
    void Update()
    {
        
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        

        

 
        Vector3 dir = playerPosition - transform.position;
        Vector3 dir2 = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);

    }

    void HitTarget()
    {
        Debug.Log("WE HIT SOMETHING");
        Destroy(gameObject);
    }
}
