using System.Collections;
using UnityEngine;

class Movement1 : MonoBehaviour
{

	Vector3 pos;                                // For movement
	float speed = 2.0f; 					 // Speed of movement
	int moveNum = StatHolder.Dice;
	int movesMade = 0;

	void Start () {
		pos = transform.position; // Take the initial position
		Debug.Log(moveNum);
	}

	void FixedUpdate () {
		if(Input.GetAxisRaw("Horizontal") < 0 && transform.position == pos && movesMade < moveNum ) {        // Left
			pos += Vector3.left;
			movesMade++;
			Debug.Log(movesMade);
		}
		if(Input.GetAxisRaw("Horizontal") > 0 && transform.position == pos && movesMade < moveNum ) {        // Right
			pos += Vector3.right;
			movesMade++;
			Debug.Log(movesMade);
		}
		if(Input.GetAxisRaw("Vertical") > 0 && transform.position == pos && movesMade < moveNum ) {        // Up
			pos += Vector3.up;
			movesMade++;
			Debug.Log(movesMade);
		}
		if(Input.GetAxisRaw("Vertical") < 0 && transform.position == pos && movesMade < moveNum ) {        // Down
			pos += Vector3.down;
			movesMade++;
			Debug.Log(movesMade);
		}
			transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);  
	}

	public void ResetDice(){
		movesMade = 0;
		Debug.Log (moveNum);
	}

	/* public float speed = 5.0f; // player speed
	public Rigidbody2D rb2D;
	private Vector3 pos; // position

	void Start()
	{
		rb2D = GetComponent<Rigidbody2D>();
		pos = transform.position; // Take the initial position
	}

	void FixedUpdate()
	{
	Move();
	}

	void Move()
		{
		// If key pressed && not moving
		if (Input.GetAxisRaw("Horizontal") < 0) // Left
			rb2D.MovePosition(rb2D.position + Vector2.left * Time.fixedDeltaTime);
		if (Input.GetAxisRaw("Horizontal") > 0) // Right
			rb2D.MovePosition(rb2D.position + Vector2.right * Time.fixedDeltaTime);
		if (Input.GetAxisRaw("Vertical") > 0) // Up
			rb2D.MovePosition(rb2D.position + Vector2.up * Time.fixedDeltaTime);
		if (Input.GetAxisRaw("Vertical") < 0) // Down
			rb2D.MovePosition(rb2D.position + Vector2.down * Time.fixedDeltaTime);

	}

*/
}