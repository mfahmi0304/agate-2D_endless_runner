using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGameOverController : MonoBehaviour
{
    public AudioSource AudioGameOver;

    // Start is called before the first frame update
    void Start()
    {
        AudioGameOver.Play();
    }

    // Update is called once per frame
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // reload
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
