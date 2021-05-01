using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanagerscript : MonoBehaviour
{
    // Start is called before the first frame update

    public static AudioClip ses_efekti;
    static AudioSource audioSrc;
    void Start()
    {
        ses_efekti = Resources.Load<AudioClip>("kutu_ses");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound()
    {
        
            
       audioSrc.PlayOneShot(ses_efekti);
      
    }
}
