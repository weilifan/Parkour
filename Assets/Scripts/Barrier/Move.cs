using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Transform barrier;
	private bool moveToLeft = true;
    public float speed = 2;
	
	// Start is called before the first frame update
    void Start()
    {
        barrier = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (barrier.position.x <= -3 && moveToLeft)
        {
            moveToLeft = false;
        }
        else if (barrier.position.x >= 3 && !moveToLeft)
            moveToLeft = true;
        barrier.position += (moveToLeft ? Vector3.left : Vector3.right) * Time.deltaTime * speed;
    }
}
