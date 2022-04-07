using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;

public class ColliderController : MonoBehaviour
{
    [SerializeField] Movement movement;
    forCanvas finish;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Plastic")
        {

            // Debug.Log("Plastic calıstı");

            Destroy(other.gameObject);
          
        }
        
        else if (other.tag == "Paper")
        {

            // skorLog();
            Destroy(other.gameObject);

        }
      
        else if (other.tag == "Finish")
        {
            Debug.Log("Finish");
           
        }
        
        
    }
    

}