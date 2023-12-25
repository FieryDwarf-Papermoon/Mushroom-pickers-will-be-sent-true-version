using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameManadger gameManadger;
    [SerializeField] Text text;
    [SerializeField] Text textWin;
    void Start()
    {
        
    }

    public void ValueSpore(bool Win)
    {
        if (Win)
        {
            textWin.text = "Вы прошли игру! Поздравляю!";
        }
        else
        {
            textWin.text = "Вас избил неправильный гриб";
        }
        text.text = "Ваш счёт : " + gameManadger.Spore;
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
