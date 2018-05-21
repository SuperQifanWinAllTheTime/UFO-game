using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontroll : MonoBehaviour {

    // Use this for initialization
    private Rigidbody2D rb2d;
    private int count;
    public Text counttext;
    public Text wintext;
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        counttext.text = "Score: " + count.ToString();
        wintext.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement*10);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp")) {
            other.gameObject.SetActive(false);
            count = count + 1;
            counttext.text = "Score: " + count.ToString();
            if (count>=11) {
                wintext.text = "You Win!";
            }
        }
    }

}
