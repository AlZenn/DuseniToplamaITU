using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementP2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player2, spawnerp2;
    public int scoreP2 = 0;
    public Rigidbody2D P2RB;
    public float playerMovementSpeedP2 = 10f;
    public Text ScoreText;
    void Start()
    {
        P2RB = GetComponent<Rigidbody2D>();
        scoreP2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        P2RB.velocity = Vector2.right * Input.GetAxis("Horizontal2") * playerMovementSpeedP2;
        ScoreText.text = scoreP2.ToString();
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("good"))
        {
            scoreP2++;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("bad"))
        {
            Destroy(other.gameObject);
            player2.SetActive(false);
            spawnerp2.SetActive(false);
        }
    }
}
