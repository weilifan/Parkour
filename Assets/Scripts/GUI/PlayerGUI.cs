using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGUI : MonoBehaviour
{
    public Transform Player;
    Vector3 screenPos;
	
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        screenPos = Camera.main.WorldToScreenPoint(Player.position);
        screenPos.y += 50f;
		screenPos.z = 0f;
		transform.position = screenPos;
    }
}
