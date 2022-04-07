using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class Spawner : MonoBehaviour
{
    forCanvas finishText;
   
    [SerializeField] GameObject obj1;
    [SerializeField] GameObject obj2;
    [SerializeField] GameObject obj3;
    [SerializeField] GameObject obj4;
    [SerializeField] GameObject obj5;
    [SerializeField] GameObject obj6;
   
  



    // Start is called before the first frame update
    void Start()
    {
        
        

        InvokeRepeating(nameof(Obj1Spawn), 1f,21f);
        InvokeRepeating(nameof(Obj2Spawn), 3.5f,23.5f);
        InvokeRepeating(nameof(Obj3Spawn), 5.5f,25.5f);
        InvokeRepeating(nameof(Obj4Spawn), 8f,28f);
        InvokeRepeating(nameof(Obj5Spawn), 11.5f,31.5f);
        InvokeRepeating(nameof(Obj6Spawn), 15.5f,35.5f);
        

        Invoke(nameof(cancelInvýkeLog), 37);
        
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }

    public void cancelInvýkeLog()
    {
        CancelInvoke();
    }
    public void Obj1Spawn()
    {
        Instantiate(obj1, this.transform.position, Quaternion.identity);
    }
    public void Obj2Spawn()
    {
        Instantiate(obj2, this.transform.position, Quaternion.identity);
    }
    public void Obj3Spawn()
    {
        Instantiate(obj3, this.transform.position, Quaternion.identity);
    }
    public void Obj4Spawn()
    {
        Instantiate(obj4, this.transform.position, Quaternion.identity);
    }
    public void Obj5Spawn()
    {
        Instantiate(obj5, this.transform.position, Quaternion.identity);
    }
    public void Obj6Spawn()
    {
        Instantiate(obj6, this.transform.position, Quaternion.identity);
    }
   


    

}
