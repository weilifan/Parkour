using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform playerTransform;
	public Vector3 deviation;
	
	// Start is called before the first frame update
    void Start()
    {
        deviation = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + deviation; 
    }
}
