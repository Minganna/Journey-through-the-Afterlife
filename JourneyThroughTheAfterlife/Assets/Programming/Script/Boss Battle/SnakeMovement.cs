using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour {

	public GameObject snake;
	Animator anim;
    public GameObject smoke;
    public bool CanAttack=false;


    void start (){
		anim = snake.GetComponent<Animator> ();
	}

	private void OnTriggerEnter ()
	{
        smoke.SetActive(true);
        StartCoroutine(SnakeAttack());
    }

    IEnumerator SnakeAttack()
    {
        yield return new WaitForSeconds(1f);
        smoke.SetActive(false);
        snake.GetComponent<Animator>().SetBool("Player Close", true);
        yield return new WaitForSeconds(2f);
        CanAttack = true;
        yield return new WaitForSeconds(2f);
        CanAttack = false;
    }

}
