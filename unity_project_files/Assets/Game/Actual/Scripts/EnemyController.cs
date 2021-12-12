using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [Header("Enemy Attributes")]
    public float spottingRadius = 15f;          //Range within enemy will start chasing
    public float attackRadius = 10f;             //Range within enemy will start attacking
    public float fireRate = 1f;                 //Fire one projectile a second
    private float fireCountdown = 0f;           //Time to wait before firing again so projectiles are spaced out
    public float playerPositionDelay = .25f;      //A delay that allows the player to avoid shots, because the shots are being thrown at where the player WAS, not where they ARE
    public Vector3 previousPlayPosition;
    Transform target;
    NavMeshAgent agent;
    Vector3 spawnPosition;


    public GameObject projectileReference;
    public Transform firePoint;


    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;                                                   //Enemy targets the player
        agent = GetComponent<NavMeshAgent>();
        spawnPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);      //Get location where enemy first spawned
    }

    // Update is called once per frame
    void Update()
    {

        playerPositionDelay -= Time.deltaTime;                                                              //Enemy is always focused on where the player WAS (by some delay), not where they ARE
        if (playerPositionDelay <= 0f)
        {
            previousPlayPosition = target.position;
            playerPositionDelay = .25f;
        }

        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= spottingRadius)                                                                     //If the player is within spotting distance, the enemy will follow
        {
            agent.SetDestination(target.position);

            if (distance <= attackRadius)                                                                   //If the player is within attacking distance, the enemy will attack
            {
                FaceTarget();                                                                               //To ensure the enemy is always facing the target while they're attacking
                if (fireCountdown <= 0f)
                {
                    Shoot();
                    fireCountdown = 1f / fireRate;
                }
                fireCountdown -= Time.deltaTime;
            }
        }
        else
        {
            gameObject.GetComponent<NavMeshAgent>().SetDestination(spawnPosition);                          //If not within spotting distance, set enemy to return to where they first spawned
        }

        
    }

    void Shoot()
    {
        Debug.Log("SHOOT!");
        GameObject projectileGO = (GameObject)Instantiate(projectileReference, firePoint.position, firePoint.rotation);     //Create projectile gameobject from our pre-made projectile in assets
        projectileGO.gameObject.tag = "Enemy";
        Projectile projectile = projectileGO.GetComponent<Projectile>();                                                

        if (projectile != null)                         
        {
            projectile.Seek(target, previousPlayPosition);
        }
    }


    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, spottingRadius);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }
}
