using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    int coins = 0;
    float hpFill = 1;
    [SerializeField] TMP_Text coinText;
    [SerializeField] Image HPImage;
    //[SerializeField] TMP_Text deathCoinText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "" + coins.ToString();
        //deathCoinText.text = "Монет собрано: " + coins.ToString();
        HPImage.fillAmount = hpFill;
    }
    public void ChangeCoins(int _number)
    {
        coins += _number;
        if(coins < 0)
        {
            coins = 0;
        }

    }
    public void ChangeHP(int _number)
    {
        hpFill = (float)_number/100;
    }
    public void Restart()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
    }
}
