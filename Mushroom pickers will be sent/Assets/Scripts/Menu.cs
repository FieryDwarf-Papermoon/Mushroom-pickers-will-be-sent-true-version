using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Starting()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
