using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    int bossmodel;
    [SerializeField] GameObject bossattackone;
    [SerializeField] GameObject bossattacktwo;
    [SerializeField] Transform player;
    [SerializeField] GameObject lose;
    [SerializeField] GameObject win;
    private void Start()
    {

    }
    public void NextRound()
    {
        if(GameManager.instance.playerHp <= 0)
        {
            lose.SetActive(true);
        }
        if(GameManager.instance.bossHP<=0)
        {
            win.SetActive(true);
        }
        if (GManger.instance.skill)
        {
            GameManager.instance.playerHp -= 800;
            //GManger.instance.playerHpBar.value = GameManager.instance.playerHp / GameManager.instance.playerHpMax;
            GameManager.instance.bossHP -= 2000;
            //GManger.instance.bossHpBar.value = GameManager.instance.bossHP / GameManager.instance.bossHpMax;
        }

        bossmodel = Random.Range(0, 8);
        if (bossmodel <= 4)
        {

            if (soldier.instance.gameObject.activeInHierarchy)
            {
                soldier.instance.saveRound -= 2;
                Instantiate(bossattackone, soldier.instance.transform);
            }
            if (Musketeers.instance.gameObject.activeInHierarchy)
            {
                Musketeers.instance.saveRound -= 1;
                Instantiate(bossattackone, Musketeers.instance.transform);
            }
            if (sappers.instance.gameObject.activeInHierarchy)
            {
                sappers.instance.saveRound -= 3;
                Instantiate(bossattackone, sappers.instance.transform);
            }
            if (!soldier.instance.gameObject.activeInHierarchy && !Musketeers.instance.gameObject.activeInHierarchy && !sappers.instance.gameObject.activeInHierarchy)
            {
                GameManager.instance.playerHp -= 500;
                GManger.instance.playerHpBar.value = GameManager.instance.playerHp / GameManager.instance.playerHpMax;
                Instantiate(bossattackone, player);
            }

        }
        if (bossmodel == 5 || bossmodel == 6)
        {
            Instantiate(bossattacktwo);
            if (soldier.instance.gameObject.activeInHierarchy || Musketeers.instance.gameObject.activeInHierarchy || sappers.instance.gameObject.activeInHierarchy)
            {
                sappers.instance.saveRound = 0;
                soldier.instance.saveRound = 0;
                Musketeers.instance.saveRound = 0;
                sappers.instance.gameObject.SetActive(false);
                soldier.instance.gameObject.SetActive(false);
                Musketeers.instance.gameObject.SetActive(false);
            }
            else
            {
                GameManager.instance.playerHp -= 1000;
                GManger.instance.playerHpBar.value = GameManager.instance.playerHp / GameManager.instance.playerHpMax;
            }


        }
        if (bossmodel == 7)
        {
            Debug.Log(7);
        }
        if (sappers.instance.saveRound > 0)
        {
            Instantiate(sappers.instance.bullet);
            sappers.instance.saveRound--;
            GameManager.instance.bossHP -= sappers.instance.attack;
            //Debug.Log(sappers.instance.saveRound) ;

            Invoke("BossHp", 0.6f);

        }
        if (sappers.instance.saveRound <= 0)
        {
            sappers.instance.gameObject.SetActive(false);
        }
        //sappers.instance.attackText.text = "" + sappers.instance.attack;
        sappers.instance.roundText.text = "" + sappers.instance.saveRound;
        if (Musketeers.instance.saveRound > 0)
        {
            Instantiate(Musketeers.instance.bullet);
            Musketeers.instance.saveRound--;
            GameManager.instance.bossHP -= Musketeers.instance.attack;

            Invoke("BossHp", 0.6f);
        }
        if (Musketeers.instance.saveRound <= 0)
        {
            Musketeers.instance.gameObject.SetActive(false);
        }
        Musketeers.instance.roundText.text = "" + Musketeers.instance.saveRound;
        if (soldier.instance.saveRound > 0)
        {
            Instantiate(soldier.instance.bullet);
            soldier.instance.saveRound--;
            GameManager.instance.bossHP -= soldier.instance.attack;

            Invoke("BossHp", 0.6f);
        }
        if (soldier.instance.saveRound <= 0)
        {
            soldier.instance.gameObject.SetActive(false);
        }
        soldier.instance.roundText.text = "" + soldier.instance.saveRound;

    }
    void BossHp()
    {
        GManger.instance.bossHpBar.value = GameManager.instance.bossHP / GameManager.instance.bossHpMax;
    }
}
