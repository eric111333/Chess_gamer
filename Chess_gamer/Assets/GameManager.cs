using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public int cardmax = 5;
    public int cardnumber
    {
        get { return _cardnumber; }
        set { _cardnumber = value; }
    }
    int _cardnumber;

}
