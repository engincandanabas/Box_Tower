using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cont_Add_Box : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Invoke("PosY", 0.6f);
        }
    }
    void PosY()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + 1f);
    }
}
