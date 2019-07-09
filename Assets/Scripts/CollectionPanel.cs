using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionPanel : MonoBehaviour
{
    //画像を指定する
    public Image icon1;
    public Image icon2;
    public Image icon3;
    public Image icon4;
    public Image icon5;

    //パネルにボールを追加する
    void SetActiveIcon(int id)
    {
        //押されたボタンのIDによって処理を振り分ける
        switch (id)
        {
            case 1:
                //画像を表示する
                icon1.enabled = true;
                break;
            case 2:
                icon2.enabled = true;
                break;
            case 3:
                icon3.enabled = true;
                break;
            case 4:
                icon4.enabled = true;
                break;
            case 5:
                icon5.enabled = true;
                break;
            default:
                break;
        }
    }
}
