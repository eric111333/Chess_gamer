using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldierCard : MonoBehaviour
{
    static public soldierCard instance = null;
    private void Awake()
    {
        instance = this;
    }
    public void OnMouseEnter()
    {

        this.GetComponent<Transform>().localScale = Vector3.one * 2;
    }
    public void OnMouseExit()
    {
        this.GetComponent<Transform>().localScale = Vector3.one * 1;
    }
    public void OnMouseDown()
    {
        if (GameManager.instance.cardPlay >= 0)
        {
            GameManager.instance.cardPlay--;
            Destroy(this.gameObject);
            GameManager.instance.cardnumber--;
            GameManager.instance.cardHandNumber--;
            if (soldier.instance.saveRound <= 0)
            {
                soldier.instance.saveRound = 3;
                soldier.instance.attack = 700;
                soldier.instance.gameObject.SetActive(true);
            }
            if (soldier.instance.gameObject.activeInHierarchy)
            {
                soldier.instance.saveRound++;
                soldier.instance.attack += 100;
            }
            soldier.instance.attackText.text = "" + soldier.instance.attack;
            soldier.instance.roundText.text = "" + soldier.instance.saveRound;
        }
    }

}
