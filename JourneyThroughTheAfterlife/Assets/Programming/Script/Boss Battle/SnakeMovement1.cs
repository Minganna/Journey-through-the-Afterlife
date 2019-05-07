using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement1 : MonoBehaviour {

	public GameObject snake;
    public GameObject smoke;
	Animator anim;
    public bool CanAttack = false;

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
        snake.GetComponent<Animator>().SetBool("Attack", true);
        yield return new WaitForSeconds(2f);
        CanAttack = true;
        yield return new WaitForSeconds(2f);
        CanAttack = false;
    }

}
