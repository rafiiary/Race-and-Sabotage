using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderCubeScript : MonoBehaviour
{
    public Camera camera;
    public GameObject car;
    public Canvas canvas;
    public Image WrongAnswerImage;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (counter > 0)
        {
            counter--;
            WrongAnswerImage.gameObject.SetActive(true);
        }
        else
        {
            WrongAnswerImage.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        canvas.gameObject.SetActive(true);
        AudioListener.pause = true;
        Time.timeScale = 0;
        Debug.Log("The car collided with " + gameObject.name + " and paused.");
    }

    public void UnpauseCar()
    {
        AudioListener.pause = false;
        Time.timeScale = 1;
        canvas.gameObject.SetActive(false);
        Debug.Log("Car was unpaused");
        BoxCollider boxCollider = gameObject.GetComponent<BoxCollider>();
        boxCollider.isTrigger = false;
        boxCollider.gameObject.SetActive(false);
        camera.transform.SetParent(car.transform);
    }

    public void CheckAndUnpause()
	{
        if (slot.first && slot.second && slot.third)
        {
            AudioListener.pause = false;
            Time.timeScale = 1;
            canvas.gameObject.SetActive(false);
            Debug.Log("Car was unpaused");
            BoxCollider boxCollider = gameObject.GetComponent<BoxCollider>();
            boxCollider.isTrigger = false;
            boxCollider.gameObject.SetActive(false);
            camera.transform.SetParent(car.transform);
        }
        else
        {
            Debug.Log("WRONG ANSWER HUEHUEHUE");
            counter = 60;
        }
	}


}
