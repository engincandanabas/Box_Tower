using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class gamecontroller : MonoBehaviour
{
    // Start is called before the first frame update

    public int Score;
    public Text TXTBoxCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score = GameObject.FindGameObjectsWithTag("Box").Length;
        TXTBoxCount.text = Score.ToString();
    }
    public void BTN_ResteGame()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
