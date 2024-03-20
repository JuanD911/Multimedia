using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ia_enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        agent.destination=player.transform.position;
    }
}
