using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotFreeAnim : MonoBehaviour {


	Animator anim;

	// Use this for initialization
	void Awake()
	{
		anim = gameObject.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		
	}


    //Functions to animated the character
    public void Walk()
    {
        anim.SetBool("Walk_Anim", true);
    }

    public void Roll()
    {
        anim.SetBool("Roll_Anim", true);
    }

    public void Stay()
    {
        anim.SetBool("Walk_Anim", false);
        anim.SetBool("Roll_Anim", false);
    }
  
    
}
