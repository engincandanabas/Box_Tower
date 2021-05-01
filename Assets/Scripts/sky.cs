using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sky : MonoBehaviour
{

    public float bgSpeed;
    public Renderer bgRend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bgRend.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0f);
    }
}
