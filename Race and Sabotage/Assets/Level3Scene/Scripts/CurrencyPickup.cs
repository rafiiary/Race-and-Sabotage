using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyPickup : MonoBehaviour
{
    public GameObject Car;
    public AudioClip CoinPickupSound;
    private AudioSource CoinSound;
    MeshRenderer renderer;
    MeshCollider collider;

    // Start is called before the first frame update
    void Start()
    {
        CoinSound = GetComponent<AudioSource>();
        renderer = gameObject.GetComponent<MeshRenderer>();
        collider = gameObject.GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("playing sound");
        CoinSound.PlayOneShot(CoinPickupSound, 0.7f);
        Debug.Log("ENTERED HERE");
        Debug.Log("MONEY COLLECTED");
        MoneyCounter.UserMoney += 1;
        Debug.Log("USER MONEY NOW IS " + MoneyCounter.UserMoney.ToString());
        CoinDestroy(gameObject);
    }

    private void CoinDestroy(GameObject gameobj)
    {
        renderer.gameObject.SetActive(false);
        collider.gameObject.SetActive(false);
       
    }
}
