using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UnityEditor;

public class GManger : MonoBehaviour
{

    static public GManger instance = null;
    private void Awake()
    {
        instance = this;
    }

    //[SerializeField] GameObject pf;
    [SerializeField] Transform cardM;
    //[SerializeField] public Transform no1; 
    [SerializeField] public Slider bossHpBar;
    [SerializeField] public Slider playerHpBar;
    public GameObject[] cards;
    private int length;
    private int index;
    private int savelength;
    public bool skill;
    [SerializeField] GameObject skillfire;
    [SerializeField] GameObject fly;
    [SerializeField] GameObject boom;
    private void Start()
    {
        CreateCard();
        GameManager.instance.bossHP = GameManager.instance.bossHpMax;
        bossHpBar.value = GameManager.instance.bossHP / GameManager.instance.bossHpMax;
        GameManager.instance.playerHp = GameManager.instance.playerHpMax;
        playerHpBar.value = GameManager.instance.playerHp / GameManager.instance.playerHpMax;
    }
    private void CreateCard()
    {
        length = transform.childCount;
        cards = new GameObject[length];
        int[] array = new int[length];

        for (int i = 0; i < array.Length;)
        {
            bool iii = true;
            int ii = Random.Range(0, length);
            for (int j = 0; j < i; ++j)
            {
                if (ii == array[j])
                {
                    iii = false;
                    break;
                }
            }
            if (iii)
            {
                array[i] = ii;
                i++;
            }
        }
        for (int i = 0; i < length; i++)
        {
            cards[i] = transform.GetChild(array[i]).gameObject;
        }
        index = length - 1;
    }

    public void GetCard()
    {
        int[] array = new int[length]; //生成了5個隨機數
        for (int i = 0; i < array.Length;)
        {
            bool iii = true;
            int ii = UnityEngine.Random.Range(0, length);//在0到10之間隨機取值
            for (int j = 0; j < i; ++j)
            {
                if (ii == array[j])
                {
                    iii = false;
                    break;
                }
            }
            if (iii)
            {
                array[i] = ii;
                i++;
            }
        }
        for (int i = 0; i < GameManager.instance.cardmax; i++)
        {

            if (GameManager.instance.cardnumber < GameManager.instance.cardmax && GameManager.instance.cardHandNumber < GameManager.instance.cardHandMax)
            {

                Instantiate(cards[array[i]], cardM);
                
                //ArrayUtility.Remove(ref cards,cards[0]);
                //if (transform.childCount == 0)
                //    CreateCard();
                GameManager.instance.cardnumber++;
                GameManager.instance.cardHandNumber++;
            }
        }

        GameManager.instance.cardnumber = 0;
    }
    public void BlackGame()
    {
        Application.Quit();
    }
    public void Skill()
    {
        skill = true;
        
        fly.SetActive(true);
        Invoke("boomlst", 1f);
    }
    void boomlst()
    {
        boom.SetActive(true);
        skillfire.SetActive(true);
    }

}
