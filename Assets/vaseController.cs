using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vaseController : MonoBehaviour
{
    Animator anim;
    [SerializeField] GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CreateCoin()
    {
        float rnd = Random.Range(0, 1f);
        if(rnd > 0.5f)
        {
            GameObject newCoin = Instantiate(coin, transform.position, transform.rotation);
            newCoin.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * 5f, ForceMode2D.Impulse);
        }
    }
    public void destroyVase()
    {
        CreateCoin();
        anim.enabled = true;
    }
    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
