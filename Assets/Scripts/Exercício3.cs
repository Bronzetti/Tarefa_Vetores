using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Exercício3 : MonoBehaviour
{
    public NavMeshAgent sphere;
    public Transform Player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sphere.SetDestination(Player.position);
    }
}
