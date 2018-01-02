using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kolizja : MonoBehaviour {

    private void OnCollisionEnter2D(Collision collision)
    {
        if (collision.collider.GetComponent<CharacterControllerMove>() != null)
        {
            SceneManager.LoadScene(0);
        }
    }
}
