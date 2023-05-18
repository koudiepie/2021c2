using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static string[] gameMsg = new string[4]; //定義遊戲訊息字串陣列
    public static int gameState;
    public GameObject green, red, gold;
    void Start(){
        gameMsg[0] = "推落綠怪物";
        gameMsg[1] = "紅怪追你快搶黃金";
        gameMsg[2] = "任務達成";
        gameMsg[3] = "任務失敗";
        gameState = 0;
    }

    void Update(){
        switch(gameState){
            case 0:
                if (green.transform.position.y < -10){ //綠怪到下地板
                    gameState = 1; //改變遊戲狀態
                    Destroy(green); //摧毀綠怪物件
                }
                break;
            case 1:
                red.SetActive(true); //啟動紅怪（預設inactive)
                gold.SetActive(true); //啟動黃金（預設inactive)
                break;
        }
    }

}
