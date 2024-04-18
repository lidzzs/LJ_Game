using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
 
public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;
 
    public TMP_Text coinText;
    public int currentCoins = 0;
 
    void Awake()
    {
        instance = this;
    }
 
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "Score: " + currentCoins.ToString();
    }
 
    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        coinText.text = "Score: " + currentCoins.ToString();
 
        if (currentCoins == 22)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex + 1);
        }
    }
   
 
}
