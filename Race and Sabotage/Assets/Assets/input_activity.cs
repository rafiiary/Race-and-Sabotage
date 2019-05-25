using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class input_activity : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject camera;
    private string which_car;

    // Static variables
    public static string chosen_car;
    public static bool game_won;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void betting_time(GameObject car)
    {
        gameObject.active = true;
        transform.position = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z);
        print(transform.position);
        button1.active = false;
        button2.active = false;
        button3.active = false;
        print("This is the car tag" + car.tag);
        if (car.tag == "car1")
        {
            which_car = "car1";
            if (SceneManager.GetActiveScene().name == "SampleScene")
            {
                game_won = false;
            }
        }
        else if (car.tag == "car2")
        {
            which_car = "car2";
            if (SceneManager.GetActiveScene().name == "SampleScene")
            {
                game_won = true;
            }
        }
        else if (car.tag == "car3")
        {
            which_car = "car3";
            if (SceneManager.GetActiveScene().name == "SampleScene")
            {
                game_won = false;
            }
        }
        chosen_car = which_car;
        print("is the game_won" + game_won.ToString());
        //camera.transform.parent = car.transform;
    }
    public void attach_camera_to_car()
    {
        print("WHICH CAR IS THE CAMERA ATTACHED TO" + which_car);
        if (which_car == "car1")
            {
            camera.transform.parent = car1.transform;
        }
        if (which_car == "car2")
        {
            camera.transform.parent = car2.transform;
        }
        if (which_car == "car3")
        {
            camera.transform.parent = car3.transform;
        }
    }
}
