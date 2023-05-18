using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class getGold : MonoBehaviour
{
    void OnCollisionEnter(Collision col){
        if (col.gameObject.name=="player"){
            gameManager.gameState = 2;
            SceneManager.LoadScene("scene3");
        }
    }
}
