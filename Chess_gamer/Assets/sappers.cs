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
    }

    public int saveRound =5;


}
