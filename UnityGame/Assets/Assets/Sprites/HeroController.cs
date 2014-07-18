using UnityEngine;
using System.Collections;

public class HeroController : MonoBehaviour {
	Animator anim;
	public float speed;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		float h = Input.GetAxis ("Horizontal");
		
		if (h != 0) 
		{
			anim.SetBool ("walking", true);
			
			float sign = Mathf.Sign (h);
			Vector2 scale = transform.localScale;
			scale.x = sign * Mathf.Abs(scale.x);
			
			transform.localScale = scale;
		}
		else 
		{
			anim.SetBool ("walking", false);
		}
	}
	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		Vector2 movement = new Vector2 (moveHorizontal, 0.0f);
		rigidbody2D.AddForce (movement * speed);
		
	}
	}






