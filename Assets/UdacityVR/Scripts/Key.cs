using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	public GameObject KeyPoofPrefab;
	public GameObject KeyPrefab;
	public Door door;

	public void OnKeyClicked()
	{
        
		Instantiate(KeyPoofPrefab, transform.position, Quaternion.Euler(-90f, 0, 0));

		Destroy(KeyPrefab);
		door.Unlock();

	
    }

}
