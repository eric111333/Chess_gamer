using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class sappersCard : MonoBehaviour
{
    [SerializeField] GameObject sapper;
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

        Instantiate(sapper, GManger.instance.no1);
        Destroy(this.gameObject);
        GameManager.instance.cardnumber--;
        GameManager.instance.cardHandNumber--;
        
    }
}
