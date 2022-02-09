using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Musketeers : MonoBehaviour
{
    static public Musketeers instance = null;
    private void Awake()
    {
        instance = this;
        this.gameObject.SetActive(false);
    }
    public int saveRound = 0;
    public int attack = 1100;
    public Text attackText;
    public Text roundText;
    public GameObject bullet;
}
