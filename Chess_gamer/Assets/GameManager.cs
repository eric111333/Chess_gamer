using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager
{ 
    static public GameManager instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameManager();
            return _instance;
        }
    }
    static GameManager _instance = null;
    public int cardmax = 2;
    public int cardHandMax = 5;
    public int cardHandNumber = 0;
    public int cardnumber
    {
        get { return _cardnumber; }
        set { _cardnumber = value; }
    }
    int _cardnumber;
    public int cardPlay = 2;
    public float bossHP=5000;
    public float bossHpMax=5000;
    
}
