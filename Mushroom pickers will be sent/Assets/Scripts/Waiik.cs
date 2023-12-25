using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waiik : MonoBehaviour
{
    [SerializeField] GameManadger gameManadger;
    [SerializeField] public float speed = 0.15f;
    [SerializeField] bool enemy = true;

    void Start()
    {
        gameManadger = GameObject.FindGameObjectWithTag("GameMasanger").GetComponent<GameManadger>();
    }

    private void FixedUpdate()
    {
        if (gameManadger.TrueGame)
        {
            gameObject.transform.Translate(new Vector3(0, 0, -speed * gameManadger.speed));
        }   
    }

    public bool TrueEnemy()
    {
        return enemy;
    }

    // Update is called once per frame

}
