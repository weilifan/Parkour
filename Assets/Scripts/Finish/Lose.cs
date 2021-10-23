using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    public GameObject loseCanvas;
	public GameObject energyCanvas;
	
	// Start is called before the first frame update
    void Start()
    {
		Time.timeScale = 1;
		loseCanvas.transform.Find("Panel").gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5 || PickReward.count <= 0)
		{
			loseCanvas.transform.Find("Panel").gameObject.SetActive(true);
			energyCanvas.transform.Find("EnergyInfoText").gameObject.SetActive(false);
			Time.timeScale = 0;
		}
    }
}
