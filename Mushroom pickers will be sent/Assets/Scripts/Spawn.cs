using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] const int wave = 100;
    [SerializeField] private int[] wavespavn = new int[wave];

    [SerializeField] int currentwave = 0;

    public float timespawn = 2f;
    private float currenttimespawn;

    [SerializeField] GameObject[] spawnposition = new GameObject[3];
    [SerializeField] GameObject[] waiik = new GameObject[2];
    [SerializeField] GameManadger gameManadger;


    void Start()
    {
        currenttimespawn = timespawn;
        InstallMass();
    }

    void InstallMass()
    {
        for (int i = 0; i < wave; i++)
        {
            wavespavn[i] = Random.Range(0, 9);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameManadger.TrueGame)
        {
            if (currenttimespawn <= 0)
            {
                if (currentwave < wave)
                {
                    currenttimespawn = timespawn / gameManadger.speed;
                    CreateWave();
                    currentwave++;
                }
                else
                {
                    gameManadger.GameOver(true);
                }
                
            }
            else
            {
                currenttimespawn -= Time.deltaTime;
            }
        }   
    }

    void CreateWave()
    {
        switch (wavespavn[currentwave])
        {
            case 0: CreateLine(0, 0, 0);break;
            case 1: CreateLine(0, 0, 1); break;
            case 2: CreateLine(0, 1, 0); break;
            case 3: CreateLine(1, 0, 0); break;
            case 4: CreateLine(1, 1, 2); break;
            case 5: CreateLine(2, 1, 2); break;
            case 6: CreateLine(1, 0, 1); break;
            case 7: CreateLine(2, 1, 0); break;
            case 8: CreateLine(2, 1, 1); break;
            case 9: CreateLine(1, 1, 2); break;
            default:
                break;
        }
    }

    void CreateLine(int Number_1, int Number_2, int Number_3)
    {
        CreateWeiik(0, Number_1 - 1);
        CreateWeiik(1, Number_2 - 1);
        CreateWeiik(2, Number_3 - 1);
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
