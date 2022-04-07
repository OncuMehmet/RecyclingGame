using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;
    

    

    
    float rotateScale;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateScale = Input.GetAxis("Horizontal");
        transform.Rotate(0f, rotateSpeed * Time.deltaTime * rotateScale, 0f);
        this.transform.Translate(moveSpeed * Time.deltaTime, 0f, 0f);
        
    }
 
   
    
}
