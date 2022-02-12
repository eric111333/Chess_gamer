using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roundCard : MonoBehaviour
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
        if (GameManager.instance.cardPlay >= 0)
        {
            GameManager.instance.cardPlay--;
            Destroy(this.gameObject);
            GameManager.instance.cardnumber--;
            GameManager.instance.cardHandNumber--;
            if (soldier.instance.gameObject.activeInHierarchy)
                soldier.instance.saveRound += 3;
            if (Musketeers.instance.gameObject.activeInHierarchy)
                Musketeers.instance.saveRound += 3;
            if (sappers.instance.gameObject.activeInHierarchy)
                sappers.instance.saveRound += 3;
            sappers.instance.roundText.text = "" + sappers.instance.saveRound;
            Musketeers.instance.roundText.text = "" + Musketeers.instance.saveRound;
            soldier.instance.roundText.text = "" + soldier.instance.saveRound;
        }
    }
}
