using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusketeersCard : MonoBehaviour
{
    static public MusketeersCard instance = null;
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
        Destroy(this.gameObject);
        GameManager.instance.cardnumber--;
        GameManager.instance.cardHandNumber--;
        if(Musketeers.instance.saveRound <=0)
        {
            Musketeers.instance.saveRound = 2;
            Musketeers.instance.attack = 1100;
            Musketeers.instance.gameObject.SetActive(true);
        }
        if(Musketeers.instance.gameObject.activeInHierarchy)
        {
            Musketeers.instance.saveRound++;
            Musketeers.instance.attack += 100;
        }
        Musketeers.instance.attackText.text = "" + Musketeers.instance.attack;
        Musketeers.instance.roundText.text = "" + Musketeers.instance.saveRound;

    }

}
