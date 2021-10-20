using UnityEngine;
using System.Collections;

public class Autowalk : MonoBehaviour
{
    Transform mainCamera = null;

    [Tooltip("With this speed the player will move.")]
    public float speed;
    [Tooltip("This is the fixed x-coordinate.")]
    public float xOffset;
	[Tooltip("This is the fixed y-coordinate.")]
    public float yOffset;

    void Start()
    {
        mainCamera = Camera.main.transform;
    }

    void Update()
    {
        if (mainCamera.transform.forward.x != 0)
        {
            Vector3 direction = new Vector3(mainCamera.transform.forward.x, 0, mainCamera.transform.forward.z).normalized * speed * Time.deltaTime;
            if(transform.rotation.eulerAngles.y != 0)
			{
				Quaternion rotation = Quaternion.Euler(new Vector3(0, -transform.rotation.eulerAngles.y, 0));
				transform.Translate(rotation * direction);
			}
			else
				transform.Translate(direction);
        }
        else
        {
            transform.Translate(xOffset, yOffset, speed * Time.deltaTime);
        }
    }
}