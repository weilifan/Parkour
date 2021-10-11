using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickReward : MonoBehaviour
{
    public Text countText;
	private float count;
	private float time = 0;
	
	void SetCount()
	{
		countText.text = "Energy" + count.ToString();
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "PickUp")
		{
			other.gameObject.SetActive(false);
			count += 1*50;
			
		}
	}
	
	// Start is called before the first frame update
    void Start()
    {
        count = 10;
		SetCount();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
		if(time > 1f)
		{
			count -= 1;
			time = 0;
		}
		SetCount();
    }
}
