using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add_box : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject kutu;

         
    void Start()
    {
        AddBox();
    }

 
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            
            Invoke("AddBox",1f);
            

        }
    }
    void AddBox()
    {
        Instantiate(kutu, transform.position, transform.rotation);
    }
    
}
