using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public float speed;
    public Text ScoreText;
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed*Time.deltaTime, 0, 0);
           
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed* Time.deltaTime, 0, 0);

        }
        ScoreText.text = Score.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="Fall")
        {
            Score += 100;
        }
        
    }
}
