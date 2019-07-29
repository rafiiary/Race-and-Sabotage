using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovingMouse : MonoBehaviour
{
    public GameObject CenterOfScreen;
    private Vector3 center;
    public GameObject WaypointFollower;
    private float distanceBetweenMouseAndCenter, totalAngleFromTurn, CenterLength, CenterAngle, MouseAngle, mouseDistance;
    public GameObject isThisTheOrigin;
    private Vector3 currentMouseTransformVector;
    private bool movedMouse=false;
    public GameObject pivot;
    private float sss;
    public GameObject car;
    private bool positive = false;
    // Start is called before the first frame update
    void Start()
    {
        center = CenterOfScreen.transform.position;
        //debug.log(center.ToString() + "this is the center");
        //debug.log(isThisTheOrigin.transform.position.ToString() + "isthisorigin");
        currentMouseTransformVector = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        //pivot.transform.position = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z);
        Rect screenRect = new Rect(0, 0, Screen.width, Screen.height);
        ////debug.log(Input.mousePosition);
        ////debug.log(Mathf.Acos(0.25f).ToString() + "ACOS OF MATH");
        if (Input.mousePosition.x != currentMouseTransformVector.x & Input.mousePosition.y != currentMouseTransformVector.y)
        {
            //debug.log(Input.mousePosition.x != currentMouseTransformVector.x);
            //debug.log(Input.mousePosition.y != currentMouseTransformVector.y);
            movedMouse = true;
            currentMouseTransformVector = Input.mousePosition;
        }
        else
        {
            movedMouse = false;
        }
        if (screenRect.Contains(Input.mousePosition)){
            //debug.log("In");
            movedMouse = false;
            //this.transform.position = new Vector3(this.transform.position.x + DifferenceInX(), this.transform.position.y + DifferenceInY(), this.transform.position.z);
            AngleBetweenCursorAndYCoordinateOfCenter();
            //debug.log((AngleBetweenCursorAndYCoordinateOfCenter() * (180 / Mathf.PI)).ToString() + "angle!!!!!!!");
            if(AngleBetweenCursorAndYCoordinateOfCenter() * (180 / Mathf.PI) > 0)
            {
                if(!positive)
                {
                    pivot.transform.eulerAngles = new Vector3(0, 0, 0);
                }
                positive = true;
                if (pivot.transform.rotation.y + 2 > 0)
                {
                    pivot.transform.Rotate(0, 2, 0);
                }
            }
            else
            {
                if (positive)
                {
                    pivot.transform.eulerAngles = new Vector3(0, 0, 0);
                }
                positive = false;
                if (pivot.transform.rotation.y - 2 < 0)
                {
                    pivot.transform.Rotate(0, -2, 0);
                }
            }
            //pivot.transform.eulerAngles = new Vector3(0, AngleBetweenCursorAndYCoordinateOfCenter() * (180 / Mathf.PI) + car.transform.rotation.y, 0); 
        }
        else
        {
            //debug.log("out");
        }
    }
    float DifferenceInX()
    {
        return Input.mousePosition.x - center.x;
    }
    float DifferenceInY()
    {
        return Input.mousePosition.y - center.y;
    }
    float lengthOfVector(float x, float y, float x1, float y1)
    {
        return Mathf.Sqrt(Mathf.Pow(x - x1, 2f) + Mathf.Pow(y - y1, 2f));
    }
    float AngleBetweenCursorAndYCoordinateOfCenter()
    {
        distanceBetweenMouseAndCenter = lengthOfVector(center.x, center.y, Input.mousePosition.x, Input.mousePosition.y);
        ////debug.log(distanceBetweenMouseAndCenter.ToString() + "distance between mouse and center");
        CenterLength = lengthOfVector(center.x, center.y, 0f, 0f);
        ////debug.log(CenterLength + "center length");
        CenterAngle = Mathf.Acos(center.x / CenterLength);
        mouseDistance = lengthOfVector(Input.mousePosition.x, Input.mousePosition.y, 0, 0);
        ////debug.log(mouseDistance.ToString() + "mouse distance");
        ////debug.log((Mathf.PI / 2 + CenterAngle) * 180/ Mathf.PI);
        MouseAngle = (Mathf.PI/2 + CenterAngle) - (Mathf.Acos((Mathf.Pow(CenterLength, 2f) + Mathf.Pow(distanceBetweenMouseAndCenter, 2f) - Mathf.Pow(mouseDistance, 2f)) / (2 * CenterLength * distanceBetweenMouseAndCenter)));
        sss = (Mathf.Acos((Mathf.Pow(CenterLength, 2f) + Mathf.Pow(distanceBetweenMouseAndCenter, 2f) - Mathf.Pow(mouseDistance, 2f)) / (2 * CenterLength * distanceBetweenMouseAndCenter)));
        ////debug.log(MouseAngle.ToString() + "mouse angle in radians");
        //the mouse is either in the second or the first 45 degrees of the 3rd quadrant
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(Input.mousePosition, forward, Color.green, 3);
        if (MouseAngle * 180 / Mathf.PI > 0)
        {
            return -MouseAngle;
        }
        //the mouse is in the first 45 degrees of the first quadrant
        else if (sss > (CenterAngle + Mathf.PI / 2))
        {
            //debug.log("FIRST QUADRANT");
            return (sss - CenterAngle - Mathf.PI / 2);
        }
        //mouse is in the rest of the 180 degrees
        else
        {
            return (float)0.0;
        }
    }
    void MoveMouse()
    {
        //debug.log("update");
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //debug.log(Input.mousePosition);
        RaycastHit hit;
        ////debug.log(Input.mousePosition);
        ////debug.log(ray.origin);
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.green, 3);
        if (Physics.Raycast(ray, out hit, 1000000, LayerMask.GetMask("UI")))
        {
            //debug.log("DID IT ENTER???");
            Debug.DrawRay(ray.origin, ray.direction * 10, Color.green, 1);
            Vector3 paddlePos = new Vector3(hit.point.x, this.transform.position.y, this.transform.position.z);
            //paddlePos.x = Mathf.Clamp(hit.point.x, minX, maxX);
            this.transform.position = paddlePos;
        }
    }
    Vector3 getCursorWorldPosition()
    {
        //finding point in world in cursor position
        //debug.log("1");
        Plane groundPlane = new Plane(Vector3.up, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
        //debug.log("2");
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(Input.mousePosition, forward, Color.green, 3);
        //debug.log(Input.mousePosition);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //debug.log("3");
        float distance;
        //simply initializing vector3 point, nothing else, this vector zero does nothing
        Vector3 point = Vector3.zero;
        //debug.log("4");
        if (groundPlane.Raycast(ray, out distance))
        {
            //debug.log("5");
            point = ray.GetPoint(distance);
        }

        return point;
    }
}
