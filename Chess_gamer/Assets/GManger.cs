using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GManger : MonoBehaviour
{


    [SerializeField] GameObject pf;
    [SerializeField] Transform cardM;

    public void GetCard()
    {
        if (GameManager.instance.cardnumber < GameManager.instance.cardmax)
        {
            Instantiate(pf, cardM);
            GameManager.instance.cardnumber++;
            Debug.Log(GameManager.instance.cardnumber);
        }

    }
    public void BlackGame()
    {
        SceneManager.LoadScene("main");
    }

}
