using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionChecker : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<CharacterControllerMove>() != null)
        {
            SceneManager.LoadScene(0);
        }
    }
}
