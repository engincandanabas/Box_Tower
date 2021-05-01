using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject GameOver;
    void Start()
    {
        GameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Box")
        {

            GameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
