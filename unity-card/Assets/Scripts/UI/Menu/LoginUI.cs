using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//开始界面（要继承UIBase）
public class LoginUI : UIBase
{
    void Awake(){
        //开始游戏
        Register("bg/startBtn").onClick = onStartGameBtn;
    }

    private void onStartGameBtn(GameObject obj, PointerEventData pData){
        //关闭login界面
        Close();

        //战斗初始化
        FightManager.Instance.ChangeType(FightType.Init);
    }
}
