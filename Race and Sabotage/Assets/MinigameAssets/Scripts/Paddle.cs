using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;
	public float minX, maxX;
    private bool mouseIn = false;
    private float ChangeinX;

	private Ball ball;
	
	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
    }
		
	// Update is called once per frame
	void Update () {
        Rect screenRect = new Rect(0, 0, Screen.width, Screen.height);
        if (screenRect.Contains(Input.mousePosition) & !mouseIn)
        {
            mouseIn = true;
            ChangeinX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;

        }
        else
        {
            mouseIn = false;
        }
		if (!autoPlay) {
			MoveWithMouse();
		} else {
			AutoPlay();
		}
	}
	
	void AutoPlay() {
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp(ballPos.x, minX, maxX);
		this.transform.position = paddlePos;
	}
	
	void MoveWithMouse () {
        //Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
        //float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        //paddlePos.x = Mathf.Clamp(mousePosInBlocks, minX, maxX);
        //this.transform.position = paddlePos;
        Rect screenRect = new Rect(0, 0, Screen.width, Screen.height);
        if (!screenRect.Contains(Input.mousePosition)) { return; }
        else
        {
            Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
            float mousePosInBlocks = this.transform.position.x + (float)((Camera.main.ScreenToWorldPoint(Input.mousePosition).x - ChangeinX) * 1.8);
            paddlePos.x = Mathf.Clamp(mousePosInBlocks, minX, maxX);
            this.transform.position = paddlePos;
        }

        //Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
        //Rect screenRect = new Rect(0, 0, Screen.width, Screen.height);
        //if (!screenRect.Contains(Input.mousePosition))
        //    return;
        //else
        //{
        //    this.transform.position = new Vector3(Camera.main.ScreenToViewportPoint(Input.mousePosition).x, this.transform.position.y, this.transform.position.z);
        //}
        //float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        //Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        
        //Debug.Log(Input.mousePosition.x);
        //Debug.DrawRay(Camera.main.ScreenPointToRay(Input.mousePosition), forward, Color.green);
        //paddlePos.x = Mathf.Clamp(mousePosInBlocks, minX, maxX);
        //RaycastHit hit;
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //if (Physics.Raycast(ray, out hit, 100.0f))
        //{
        //    Debug.Log("it has entered");
        //    this.transform.position = new Vector3(this.transform.position.x + Input.mousePosition.x, this.transform.position.y);
        //}
        //this.transform.position = new Vector3(Input.mousePosition.x, this.transform.position.y, 0f); ;
    }
}

