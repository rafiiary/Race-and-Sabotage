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


        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 10000, LayerMask.GetMask("LoadingScenes")))
        {
            Vector3 paddlePos = new Vector3(hit.point.x, this.transform.position.y, this.transform.position.z);
            this.transform.position = paddlePos;
        }
    }
}

