using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Detect_Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {   
        
        if (other.CompareTag("Player"))
        {
            // Debug.Log("You are won");
            SceneManager.LoadScene("Win_Scene");
        }
    }
}
