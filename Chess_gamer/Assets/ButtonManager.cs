using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    private void Start()
    {
        
    }
    public void NextRound()
    {
        if(sappers.instance.saveRound>0)
        { 
            sappers.instance.saveRound--;
            GameManager.instance.bossHP -= 500;
            Debug.Log(GameManager.instance.bossHP) ;
            GManger.instance.bossHpBar.value = GameManager.instance.bossHP / GameManager.instance.bossHpMax;
            if (sappers.instance.saveRound == 0)
            {
                Destroy(sappers.instance.gameObject);

            }
        }



    }
}
