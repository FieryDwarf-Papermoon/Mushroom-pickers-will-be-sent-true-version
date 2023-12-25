using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Player : MonoBehaviour
{
    [SerializeField] GameManadger gameManadger;
    [SerializeField] Animator animator;
    [SerializeField] int CurentPosition = 2;
    [SerializeField] float H = 1.25f;
    private int walkMode = 0;
    private float speed = 0.1f;
    private float startX = 0;


    public void NewPosition(bool Lefter)
    {
        if (gameManadger.TrueGame && walkMode == 0)
        {
            if (Lefter)
            {
                ChangePosition(1);
            }
            else
            {
                ChangePosition(-1);
            }
            
        }
    }

    private void FixedUpdate()
    {
        if (walkMode != 0)
        {
            gameObject.transform.Translate(new Vector3(speed * walkMode * H, 0, 0));

            if (walkMode > 0)
            {
                if (gameObject.transform.position.x >= (startX + walkMode * H))
                {
                    FinalPos();
                }
            }
            else
            {
                if (gameObject.transform.position.x <= (startX + walkMode * H))
                {
                    FinalPos();
                }
            }
        }
    }

    void FinalPos()
    {
        //Debug.Log(startX + walkMode * H);
        walkMode = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Waiik>() != null)
        {
            if (collision.gameObject.GetComponent<Waiik>().TrueEnemy())
            {
                gameManadger.GameOver(false);
                animator.Play("DAMAGED01");
            }
            else
            {
                gameManadger.Spore++;
                gameManadger.UpdateSpore();
                Destroy(collision.gameObject);
            }
        }
    }

    private void ChangePosition(int I)
    {
        int controlPosition = CurentPosition + I;
        if (controlPosition > 0 && controlPosition < 4)
        {
            CurentPosition += I;
            walkMode = I;   
            startX = gameObject.transform.position.x;
        }

    }

    //private void ChangePosition(int I)
    //{
    //    int controlPosition = CurentPosition + I;
    //    if (controlPosition > 0 && controlPosition < 4)
    //    {
    //        CurentPosition += I;

    //        Vector3 vector3 = new Vector3(I * H,0,0);
    //        gameObject.transform.Translate(vector3);
    //    }

    //}

}
