using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TestAI : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    private GameObject player;
    private void Awake()
    {
        player = GameObject.Find("Player");
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        navMeshAgent.destination = player.transform.position;
    }
}
