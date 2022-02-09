using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sappers : MonoBehaviour
{

    static public sappers instance = null;
    private void Awake()
    {
        instance = this;
        this.gameObject.SetActive(false);
    }

    public int saveRound =0;
    public int attack = 400;
    public Text attackText;
    public Text roundText;
    public GameObject bullet;
}
