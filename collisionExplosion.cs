using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionExplosion : MonoBehaviour
{
    public GameObject explosionPrefab;
    void OnCollisionEnter(){
        GameObject exps = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(exps, 3f);
    }
}
