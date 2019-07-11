using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class AnimationShower : MonoBehaviour
{
    public Animation animation;
    public Camera flybycam;
    public Canvas puzzlecanvas;
    public GameObject car;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = flybycam.GetComponent<Animator>();
        car.gameObject.SetActive(false);
        puzzlecanvas.gameObject.SetActive(false);
        animation.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("FlybyCam"))
        {
            Debug.Log("ANIMATION ENDED");
            puzzlecanvas.gameObject.SetActive(true);
            flybycam.gameObject.SetActive(false);
        }
    }
}
