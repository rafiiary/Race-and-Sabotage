using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    float currentTime;
    float startingTime = 5.5f;
    public GameObject barrier;
    public GameObject canvas;
    public GameObject drag;
    public GameObject count;
    public GameObject fixingBug;

    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        fixingBug.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (canvas.active == true)
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");
            if (currentTime <= 0)
            {
                currentTime = 0;
                Destroy(barrier);
                count.SetActive(false);
                fixingBug.SetActive(true);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        canvas.SetActive(true);
        if (drag.active == true)
        {
            drag.SetActive(false);
        }
    }
}
