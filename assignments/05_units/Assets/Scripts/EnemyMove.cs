using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform playerunit;
    public LayerMask ground, player;

    //patrol
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;

    //States
    public float sightRange, attackRange;
    public bool playerInSight, playerInAttack;

    private void Awake()
    {
        playerunit = GameObject.Find("player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        playerInSight = Physics.CheckSphere(transform.position, sightRange, player);
        playerInAttack = Physics.CheckSphere(transform.position, attackRange, player);

        if (!playerInSight && !playerInAttack) Patrolling();
        if (playerInSight && !playerInAttack) ChasePlayer();
        if (playerInSight && playerInAttack) AttackPlater();

    }
    private void Patrolling()
    {
        if (!walkPointSet) SearchWalkPoint();
        if (walkPointSet)
        {
            agent.SetDestination(walkPoint);

        }

        Vector3 distanceWalkPoint = (transform.position - walkPoint).normalized;

        //reached walkpoint
        if (distanceWalkPoint.magnitude < 1f)
        {
            walkPointSet = false;
        }
    }

    private void SearchWalkPoint()
    {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);
        walkPoint = new Vector3(transform.position.x * randomX, transform.position.y, transform.position.z * randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, ground))walkPointSet = true;

    }
    private void ChasePlayer()
    {
        agent.SetDestination(playerunit.position);
    }
    private void AttackPlater()
    {
        agent.SetDestination(transform.position);
        transform.LookAt(playerunit);
        if (!alreadyAttacked)
        {
            //attack code
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }
    private void ResetAttack()
    {
        alreadyAttacked = false;
    }
}
