using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenwrapping : MonoBehaviour
{
 public float aWidth = 80;
 public float aHeight = 60;
 public float x = 0;
 public float z = 0;
void Start(){
}


    void Update(){
if(GetComponent<Renderer>().isVisible)
        {
        }
else
{
        transform.position = new Vector3(Mathf.Repeat(2.1f, 2f), transform.position.y, transform.position.z);
        transform.position = new Vector3(Mathf.Repeat(2.1f, 2f), transform.position.x, transform.position.y);
}
	x = Mathf.Repeat(x, aWidth);
	z = Mathf.Repeat(z, aHeight);
    }
}
