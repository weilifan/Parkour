using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rig;
	public float force = 5;
	
	public void PlayerJump()
	{
		rig = GetComponent<Rigidbody>();
		if (transform.position.y > 1.5f) 
			return;
		else
			rig.velocity += Vector3.up * force;
	}
}
