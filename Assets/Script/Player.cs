using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera myCam;
    public float speed = 0.2f;

    public float sense = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    void Move()
    {
        float x = Input.GetAxis("Horizontal");
 
        this.transform.position += new Vector3(x * sense * Time.deltaTime, 0, speed);
        myCam.transform.position += new Vector3(0, 0, speed);

    }
}
