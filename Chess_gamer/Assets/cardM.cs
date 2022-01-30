using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class cardM : MonoBehaviour
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
    }
}
