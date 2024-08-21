using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public GameObject gameovercanvas;
     
    // Start is called before the first frame update
    void Start()
    {
        gameovercanvas.SetActive(false);
        Time.timeScale = 1; 
    }

    public void GameOver(){
        gameovercanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void Replay(){
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
