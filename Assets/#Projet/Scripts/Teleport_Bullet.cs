using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.SceneManagement;

public class Teleport_Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player; 
    void OnCollisionEnter(Collision collision) 
    {
        Debug.Log("BOOM");

        if (!collision.collider.CompareTag("ReBound")) 
        {
            Destroy(gameObject);
        }
        
        // SceneManager.LoadScene("Win_Scene");
        Debug.Log("Point de contact : " + collision.GetContact(0).point);
        if(collision.collider.CompareTag("Teleport")) 
        {
            player.transform.position = collision.GetContact(0).point;
        }
    }

}
