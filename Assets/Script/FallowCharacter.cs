using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FallowCharacter : MonoBehaviour
{
  
    public GameObject ponto;
    public float diction = 1;
    NavMeshAgent NavMesh;

    float distacia;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
     
          NavMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        distacia = Vector3.Distance(player.transform.position, transform.position);// distacia do player


        if(distacia <= 4)

         NavMesh.SetDestination(player.transform.position);

        else
        NavMesh.SetDestination(ponto.transform.position );

    }
}
