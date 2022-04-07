using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Skor : MonoBehaviour
{
    
    public static int skorToplam;
    public static int skorPaper;
    public static int skorPlastic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Paper") && gameObject.tag=="YCop")//yesil=paper
        {
            skorPaper+=5;
            //Debug.Log("paper"+skorPaper);
            
            ToplamSkor();
        }
        if (other.gameObject.CompareTag("Plastic") && gameObject.tag == "SCop")//sari=plastic//
        {
            skorPlastic+=10;
           // Debug.Log("plastic"+skorPlastic);
            
            ToplamSkor();
            
        }
    }
    public void ToplamSkor()
    {
        skorToplam = skorPaper + skorPlastic;
       
        Debug.Log("toplam:" + skorToplam);
       
    }
}
