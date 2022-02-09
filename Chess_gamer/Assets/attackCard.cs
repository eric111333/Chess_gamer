using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackCard : MonoBehaviour
{
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
        if (soldier.instance.gameObject.activeInHierarchy)
            soldier.instance.attack += 500;
        if(Musketeers.instance.gameObject.activeInHierarchy)
            Musketeers.instance.attack += 500;
        if (sappers.instance.gameObject.activeInHierarchy)
            sappers.instance.attack += 500;
        soldier.instance.attackText.text = "" + soldier.instance.attack;
        Musketeers.instance.attackText.text = "" + Musketeers.instance.attack;
        sappers.instance.attackText.text = "" + sappers.instance.attack;
    }
}
