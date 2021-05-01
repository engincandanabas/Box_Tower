using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform ContAddBox;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ContAddBox.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, ContAddBox.transform.position.y - 1.0f,transform.position.z);
           
        }
    }
}
