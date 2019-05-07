using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour {


	public JumpOnCanoe Jump;
	public GameObject LightDirection;
	public Animator CollectCoin;
	public JessesPlayerMovement movements;
	bool fall=true;
    public GameObject PileofAsh;
    public Camera cam;
    public AudioClip soundclip;
    public AudioSource soundsource;

    void Start()
    {
        soundsource.clip = soundclip;
    }

    void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Floor") {
            
            CollectCoin.SetBool ("PickUpCoin", true);
            soundsource.Play();
            movements.Playtime = false;
			if (fall) {
				fall = false;
				StartCoroutine (CoinTime ());
			}

		}
	}


	IEnumerator CoinTime()
	{
		yield return new WaitForSeconds (1f);
		CollectCoin.SetBool ("PickUpCoin", false);
		movements.Playtime = true;
		Jump.CoinCollected = true;
		LightDirection.SetActive (true);
        PileofAsh.SetActive(true);
        PileofAsh.transform.parent = null;
        cam.cullingMask=1<<0;
		Destroy (gameObject);

	}

}
