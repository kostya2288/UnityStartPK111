using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField]GameObject uicontroller;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        uicontroller = GameObject.Find("Canvas");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            //переписать на синглтон
            uicontroller.GetComponent<UIController>().ChangeCoins(1);
            Destroy(gameObject);  
        }
    }
}
