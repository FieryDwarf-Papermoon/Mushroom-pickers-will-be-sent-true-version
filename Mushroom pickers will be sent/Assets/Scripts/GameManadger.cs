using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManadger : MonoBehaviour
{
    [SerializeField] Text textspore;
    [SerializeField] GameOver gameOver;
    [SerializeField] GameObject games;

    public bool TrueGame;
    private bool _wins;
    public int Spore = 0;
    public float speed = 1;

    public float timespawn = 1f;
    private float currenttimespawn;

    public void GameOver(bool Win)
    {
        TrueGame = false;
        _wins = Win;
    }

    public void UpdateSpore()
    {
        textspore.text = Spore.ToString();
        if (Spore % 10 == 0)
        {
            speed = 1f + Spore / 100f;
        }
        //Debug.Log(speed);
    }

    public void FixedUpdate()
    {
        if (!TrueGame)
        {
            if (currenttimespawn <= 0)
            {
                gameOver.gameObject.SetActive(true);
                gameOver.ValueSpore(_wins);
                games.SetActive(false);
            }
            else
            {
                currenttimespawn -= Time.deltaTime;
            }
        }
    }


    private void Start()
    {
        TrueGame = true;
        currenttimespawn = timespawn;
    }
}
