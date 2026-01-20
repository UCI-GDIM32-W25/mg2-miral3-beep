using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    [SerializeField] private SpriteRenderer spriteRenderer;
    public bool gameStarted = false;
    public float _speed = 0.5f;
    private float currentspeed;
    public TextMeshProUGUI scoreText;

    public Transform _coinSpawnPoint;
    public int score =0;
    private void Awake()
    {
        Instance = this;

        currentspeed = _speed;

    }

    private void Update()
    {
        if (gameStarted)
        {
            currentspeed += Time.deltaTime;

            spriteRenderer.material.mainTextureOffset += new Vector2(x:currentspeed * Time.deltaTime, y:0); 
        }
    }
    public void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
    




}