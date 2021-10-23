using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardSpawn : MonoBehaviour
{
    public GameObject reward;
	public Transform playerTransform;
	
	// Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 5, 3);
    }
	
	void SpawnObject()
	{
		reward.SetActive(true);
		float x = Random.Range(-3.5f,3.5f);
		float z = Random.Range(playerTransform.position.z + 5.0f,playerTransform.position.z + 10.0f);
		Instantiate(reward, new Vector3(x, 1.5f, z), reward.transform.rotation);
	}
}
