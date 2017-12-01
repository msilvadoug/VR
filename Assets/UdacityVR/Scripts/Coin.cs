using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab

	public GameObject CoinPoofPrefab;
	public GameObject Poof;


    public void OnCoinClicked() {
        
		Instantiate(CoinPoofPrefab, transform.position, Quaternion.Euler (-90, 0, 0));
		Destroy (Poof);	

    }

}
