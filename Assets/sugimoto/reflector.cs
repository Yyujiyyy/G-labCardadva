using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "UniqueEffects/Attack")]
public class Reflector : UniqueEffect
{
    public override void Execute(Card card, Card flontCard, Battler player, Enemy enemy, Text message)
    {
        
    }

    //一枚前のカードの追加効果処理
    public int FlontBufff(Card card, Card flontCard)
    {

        float attackValue = (int)card.Base.CardStatus.Attack_Status;


        if (flontCard == null)
        {
            return (int)attackValue;
        }
        else
        {
            string cardName = flontCard.Base.CardName;
            FlontBuff foundBuff = card.Base.FlontBuff.Find(buff => buff.flontCard == cardName);

            if (foundBuff == null)
            {
                return (int)attackValue;
            }
            attackValue *= foundBuff.buff;
            return (int)attackValue;
        }
    }


    public void reflector(Battler player, Enemy enemy,Text meesage, int Hit) 
    {
        float Enemydamege = Hit * 0.5f;

        enemy.Base.EnemyLife -= (int)Enemydamege*3;

    }


    
}
