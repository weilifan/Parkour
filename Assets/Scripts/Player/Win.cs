using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winCanvas;
	public GameObject energyCanvas;
	
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			winCanvas.transform.Find("Panel").gameObject.SetActive(true);
			energyCanvas.transform.Find("EnergyInfoText").gameObject.SetActive(false);
			Time.timeScale = 0;
		}
	}
	
	// Start is called before the first frame update
    void Start()
    {
		winCanvas.transform.Find("Panel").gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
