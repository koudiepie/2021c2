using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class capture : MonoBehaviour
{
    public GameObject target;
    public float moveSpeed = 1f;
    void Update(){
        Vector3 v = (target.transform.position - transform.position).normalized 
                      * moveSpeed * Time.deltaTime; //計算追捕向量
        transform.Translate(v); //根據v移動
    }
    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject == target){
            gameManager.gameState = 3;
            SceneManager.LoadScene("scene2"); //失敗場景
        }
    }

}
