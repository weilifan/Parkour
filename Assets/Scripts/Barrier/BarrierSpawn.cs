using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSpawn : MonoBehaviour
{
    public GameObject barrier;
	public GameObject movingBarrier;
	public Transform playerTransform;
	
	// Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 7, 3);
    }
	
	void SpawnObject()
	{
		float x = Random.Range(-2.5f,2.5f);
		float z = Random.Range(playerTransform.position.z + 5.0f,playerTransform.position.z + 10.0f);
		float type = Random.Range(0.0f,1.0f);
		if(type < 0.5)
			Instantiate(barrier, new Vector3(x, 1, z), Quaternion.identity);
		else
			Instantiate(movingBarrier, new Vector3(x, 1, z), Quaternion.identity);
	}
}
