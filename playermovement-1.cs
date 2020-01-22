using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
        public float speedLimit = 100f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) 
	{
		Vector3 newRotation = transform.rotation.eulerAngles;
		newRotation.y += 10;
		transform.rotation = Quaternion.Euler (newRotation);
	}    
	else if (Input.GetKey(KeyCode.LeftArrow)) 
	{
		Vector3 newRotation = transform.rotation.eulerAngles;
		newRotation.y -= 10;
		transform.rotation = Quaternion.Euler (newRotation);
	}
	if (Input.GetKey(KeyCode.UpArrow)) 
	{
		GetComponent<Rigidbody>().AddForce(transform.forward * 1000 * Time.deltaTime);
	}
rigidbody.velocity = Vector3.ClampMagnitude(rigidbody.velocity, speedLimit);
    }
}
