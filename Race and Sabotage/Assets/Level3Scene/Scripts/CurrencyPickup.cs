using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyPickup : MonoBehaviour
{
    public GameObject Car;
    public AudioClip CoinPickupSound;
    public AudioSource CoinSound;
    //MeshRenderer renderer;
    //MeshCollider collider;

    // Start is called before the first frame update
    void Start()
    {
        //CoinSound = GetComponent<AudioSource>();
        //renderer = gameObject.GetComponent<MeshRenderer>();
        //collider = gameObject.GetComponent<MeshCollider>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        ////debug.log("playing sound");
        CoinSound.PlayOneShot(CoinPickupSound, 0.7f);
        ////debug.log("ENTERED HERE");
        ////debug.log("MONEY COLLECTED");
        MoneyCounter.UserMoney += 2;
        ////debug.log("USER MONEY NOW IS " + MoneyCounter.UserMoney.ToString());
        Destroy(gameObject);
        //CoinDestroy(gameObject);
    }
    
    private void CoinDestroy(GameObject gameobj)
    {
        //renderer.gameObject.SetActive(false);
        //collider.gameObject.SetActive(false);
       
    }
}
