using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarInWater : MonoBehaviour
    {
        private CarController car;
        private float previousSpeed;

        // Start is called before the first frame update
        void Start()
        {

        }

        void Awake()
        {
            car = GetComponent<CarController>();
            previousSpeed = car.m_Topspeed;
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Dreamcar01"))
            {
                car.m_Topspeed = 10;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Dreamcar01"))
            {
                car.m_Topspeed = previousSpeed;
            }
        }
    }
}

