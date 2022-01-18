using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed_f;
    public float jump_f;
    float horizontalMove = 0f;
    bool jump = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();

        
        
        
    }
    void Move()
    {

        if (Input.GetKey(KeyCode.A))
        {
            print("left");


            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed_f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Right");


            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed_f);
        }

    }   

    
    void Jump()
    {
       

        if (Input.GetKey(KeyCode.Space))
        {
            jump = true;
           
          
        }    
    }        

    

}   
    
        

    


