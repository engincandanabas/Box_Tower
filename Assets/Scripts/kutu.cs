using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kutu : MonoBehaviour
{
   
    void Start()
    {
        transform.SetParent(GameObject.FindGameObjectWithTag("Add_Box").transform);
        GetComponent<Rigidbody2D>().gravityScale = 0;
        transform.position = GameObject.FindGameObjectWithTag("Add_Box").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.parent = null;
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        soundmanagerscript.PlaySound();
    }
}
