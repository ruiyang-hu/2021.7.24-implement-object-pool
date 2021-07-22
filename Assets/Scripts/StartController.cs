using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartController : MonoBehaviour
{
    private Animator animator;
    new private Collider2D collider;
    public LayerMask checkLayer;
    public bool flagTouched = false;
   
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (collider.IsTouchingLayers(checkLayer))
        {
            flagTouched = true;
            animator.SetBool("go", true);
        }
    }

    public static bool FlagTouched(StartController sc)
    {
        return sc.flagTouched;
    }

    //public bool FlagTouched
    //{
    //    get
    //    {
    //        return flagTouched;
    //    }
    //}
}
