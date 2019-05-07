using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeDamagesPlayer : MonoBehaviour {
    public SnakeMovement snakeattack;
    public SnakeMovement1 snakeattack1;
    public Slider healthBar;
    public Animator player;
    public int snakes = 0;
    public bool damage=false;



    void OnTriggerStay(Collider other)
    {
        if(snakeattack.CanAttack==true&&other.tag=="Player")
        {
            player.SetBool("SnakeAttack", true);
            StartCoroutine(stopAnimation());

            if (snakes == 0)
            {
                if (healthBar.value > 40)
                {
                    healthBar.value -= 1;

                       

                }
            }
            if (snakes == 1)
            {
                if (healthBar.value > 30)
                {
                    healthBar.value -= 1;
                }
            }
            if (snakes == 2)
            {
                if (healthBar.value > 20)
                {
                    healthBar.value -= 1;
                }
            }
            if (snakes == 3)
            {
                if (healthBar.value > 10)
                {
                    healthBar.value -= 1;
                }
            }
            if (snakes == 4)
            {
                if (healthBar.value > 0)
                {
                    healthBar.value -= 1;
                }
            }

         
        }
        if (snakeattack1.CanAttack == true && other.tag == "Player")
        {
            player.SetBool("SnakeAttack", true);
            StartCoroutine(stopAnimation());

            if (snakes == 0)
            {
                if (healthBar.value > 40)
                {
                    healthBar.value -= 1;



                }
            }
            if (snakes == 1)
            {
                if (healthBar.value > 30)
                {
                    healthBar.value -= 1;
                }
            }
            if (snakes == 2)
            {
                if (healthBar.value > 20)
                {
                    healthBar.value -= 1;
                }
            }
            if (snakes == 3)
            {
                if (healthBar.value > 10)
                {
                    healthBar.value -= 1;
                }
            }
            if (snakes == 4)
            {
                if (healthBar.value > 0)
                {
                    healthBar.value -= 1;
                }
            }


        }
    }

    IEnumerator stopAnimation()
    {
        yield return new WaitForSeconds(1f);
        player.SetBool("SnakeAttack", false);
    }
}
