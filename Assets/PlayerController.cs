    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using UnityEngine.UI;

    public class PlayerController : MonoBehaviour
    {
    public GameObject player1, spawnerp1;
        public int score = 0;
        public Text scoreText;
        public GameObject gameOverPanel;
        
        public Rigidbody2D RBplayer;
        public float playerMovementSpeed = 10f;
        void Start()
        {
            RBplayer = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            scoreText.text = score.ToString();
            RBplayer.velocity = Vector2.right * Input.GetAxis("Horizontal") * playerMovementSpeed;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("good"))
            {
                score++;
                Destroy(other.gameObject);
            }
            if (other.gameObject.CompareTag("bad"))
            {
                Destroy(other.gameObject);
            player1.SetActive(false);
            spawnerp1.SetActive(false);
            }
        }

        public void RestartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1f;
            
        }
    }
