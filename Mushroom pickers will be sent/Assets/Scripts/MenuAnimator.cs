using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class MenuAnimator : MonoBehaviour
{
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.Play("WAIT00");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
