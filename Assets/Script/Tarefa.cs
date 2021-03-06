using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;

public class Tarefa : MonoBehaviour
{

   
    public float velocidade;
    
    public int inde = 0;
   
    public List <GameObject> pontos;


  
    void Update()
    {
     transform.position = Vector3.MoveTowards(transform.position, pontos[inde].transform.position, velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pont"))
        {
            next();
           
        }
      
     }

    public void  next()
    {
        inde++;
        if (inde >= pontos.Count)
        {
            inde =0;
        }

       
      
    }

}



