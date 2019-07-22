using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car3lose : MonoBehaviour
{
    public GameObject camera;
    public GameObject losing_canvas;
    public GameObject win_canvas;
    public string car_tag;
    public float time_to_delay;

    AudioSource source;
    public AudioClip lose_sound;
    float volume = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        losing_canvas.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {

        source = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (camera.transform.parent.tag == car_tag)
        {
            //print("does it trigger the trigger car3");
            StartCoroutine(Example());
        }
        //if (camera.transform.parent.tag == car_tag)
        //{
            ////print("does it trigger the trigger car1");
            //losing_canvas.active = true;
            //win_canvas.SetActive(false);
        //}
    }
    public IEnumerator Example()
    {
        //debug.log("ENTEREDDDDDDD");
        yield return new WaitForSeconds(time_to_delay);
        losing_canvas.active = true;
        win_canvas.SetActive(false);
        source.PlayOneShot(lose_sound, volume);
    }
}
