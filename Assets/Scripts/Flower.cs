using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    Animator anim;
    bool IsOpen;
	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}

    private void OnMouseDown()
    {
        IsOpen = !IsOpen;
        anim.SetBool("IsOpen", IsOpen);
    }
}
