using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{

	[Header ("Controles Porta")]
	public bool locked = true;
	public bool opening = false;

	[Header ("Animações")]
	public Animator openDoor;
	public Animator Chest;

	[Header ("Som")]
	public AudioSource SoundSource;
	public AudioClip PortaAbrindo		= null;
	public AudioClip PortaFechada 		= null;
	public GameObject box;

	void Update() {
       

	
	}

    public void OnDoorClicked() {
        
		if (locked == true) {

			SoundSource.clip = PortaFechada;
			SoundSource.Play ();

		} if (opening == true) {

			SoundSource.clip = PortaAbrindo;
			SoundSource.Play ();
			openDoor.SetBool ("Open", true);
			Chest.SetBool ("Open", true);
			GetComponent<Collider>().enabled = false;


		}

    }

    public void Unlock()
    {
		
		locked = false;
		opening = true;

    }
}
