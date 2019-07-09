/*
1. このスクリプトにIPointerClickHandlerが追加されている
2. HierarchyにEventSystemがある
3. Main CameraにPhysicsRaycasterがアタッチされている
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ball : MonoBehaviour, IPointerClickHandler
{
    //このボールのIDを設定する
    public int id;

    //クリックされた時に実行される。
    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject CollectionPanel = GameObject.Find("CollectionPanel");
        CollectionPanel.SendMessage("SetActiveIcon", id);

        Destroy(gameObject);
    }
}
