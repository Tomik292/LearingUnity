using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Diagnostics;

public class EnemynavMesh : MonoBehaviour {

    public Transform enemy;
    public NavMeshAgent navMesh;

	// Use this for initialization
	void Start ()
    {

        navMesh = GetComponent<NavMeshAgent>();
        enemy = GameObject.FindGameObjectWithTag("Player").transform;

    }
	
	// Update is called once per frame
	void Update ()
    {

        navMesh.destination = enemy.position;
	}
}
