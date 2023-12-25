using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTree : MonoBehaviour
{
    [SerializeField] GameObject[] spawnposition = new GameObject[2];
    [SerializeField] GameObject[] waiik = new GameObject[1];
    [SerializeField] GameManadger gameManadger;

    int currentwave = 0;
    public float timespawn = 0.5f;
    private float currenttimespawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameManadger.TrueGame)
        {
            if (currenttimespawn <= 0)
            {
                currenttimespawn = timespawn/gameManadger.speed;
                CreateWeiik(0, 0);
                CreateWeiik(1, 0);

            }
            else
            {
                currenttimespawn -= Time.deltaTime;
            }
        }
    }

    void CreateWeiik(int Number, int Value)
    {
        Vector3 vector = new Vector3(spawnposition[Number].transform.position.x, spawnposition[Number].transform.position.y, spawnposition[Number].transform.position.z + 1);
        if (Value >= 0)
        {
            Instantiate(waiik[Value], vector, Quaternion.identity);
        }
    }
}
