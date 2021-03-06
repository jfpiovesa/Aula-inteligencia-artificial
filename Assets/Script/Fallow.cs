using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;


    public class Fallow : MonoBehaviour
    {      
        public float velocidade;

        float distacia;       

        public GameObject player;

        void Update()
        {
           distacia = Vector3.Distance(player.transform.position, transform.position);// disatacia do player



            if (distacia <= 4) // se a distacia for x  segue se não 
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocidade * Time.deltaTime);
        }
    }
