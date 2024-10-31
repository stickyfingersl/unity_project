using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;
//防御卡
public class DefendCard : CardItem
{
    public override void OnEndDrag(PointerEventData eventData)
    {
        if (TryUse() == true)
        {
            //使用效果
            int val = int.Parse(data["Arg0"]);
            //播放使用后的声音（每张卡使用的声音可能不一样）
            AudioManager.Instance.PlayEffect("Effect/healspell");// 这个字段可以配置到表中

            //增加防御力
            FightManager.Instance.DefenseCount += val;
            // 刷新防御文本
            UIManager.Instance.GetUI<FightUI>("FightUI").UpdateDefense();
            Vector3 pos = Camera.main.transform.position;
            pos.y = 0;
            PlayEffect(pos);
        }else{
            base.OnEndDrag(eventData);
        }
    }
}
