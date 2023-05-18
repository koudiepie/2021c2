using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showMessage : MonoBehaviour
{
    Text msg;
    void Start(){
        msg = GetComponent<Text>();
    }
    void Update()
    {
	//GUI 字串顯示內容
        msg.text= gameManager.gameMsg[gameManager.gameState]+ "\n" + "10160000 王大明";
    }

}
