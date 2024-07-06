using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestruccionContacto : MonoBehaviour
{
    public GameObject esplosion;
    public GameObject playerExplosion;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Limite")) return;

        Instantiate (esplosion, transform.position, transform.rotation);

        if (other.CompareTag("Player"))
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
     
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
