using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class sappersCard : MonoBehaviour
{
    //[SerializeField] GameObject sapper;
    static public sappersCard instance = null;
    //public bool sappershave;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {

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
            //if (sappers.instance.saveRound >0)
            //sappers.instance.gameObject.SetActive(true);
            Destroy(this.gameObject);
            GameManager.instance.cardnumber--;
            GameManager.instance.cardHandNumber--;
            if (sappers.instance.saveRound <= 0)
            {
                sappers.instance.saveRound = 4;
                sappers.instance.attack = 400;
                sappers.instance.gameObject.SetActive(true);
            }
            if (sappers.instance.gameObject.activeInHierarchy)
            {
                sappers.instance.saveRound++;
                sappers.instance.attack += 100;
            }
            sappers.instance.attackText.text = "" + sappers.instance.attack;
            sappers.instance.roundText.text = "" + sappers.instance.saveRound;
        }
    }
}
