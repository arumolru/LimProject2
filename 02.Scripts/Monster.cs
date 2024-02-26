using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{
    Rigidbody rb;

    public Transform player;

    private NavMeshAgent agent;

    public float moveSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        agent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        if(player!=null)
        {
            agent.SetDestination(player.position);
            agent.speed = moveSpeed;
        }
    }
}
