using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MManger : MonoBehaviour
{


    public void StartGame()
    {
        SceneManager.LoadScene("game1");
    }
}
