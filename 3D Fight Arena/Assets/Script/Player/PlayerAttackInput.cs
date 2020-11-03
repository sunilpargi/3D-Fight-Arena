using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackInput : MonoBehaviour
{
    private CharacterAnimations playerAnimation;

    public GameObject attackPoint;

    

    void Awake()
    {
        playerAnimation = GetComponent<CharacterAnimations>();
       
    }

    void Update()
    {

        // defend when J pressed DOWN
        if (Input.GetKeyDown(KeyCode.J))
        {

            playerAnimation.Defend(true);

           

        }

        // release Defence when J Is released
        if (Input.GetKeyUp(KeyCode.J))
        {

            playerAnimation.UnFreezeAnimation();
            playerAnimation.Defend(false);

           

        }

        if (Input.GetKeyDown(KeyCode.K))
        {

            if (Random.Range(0, 2) > 0)
            {

                playerAnimation.Attack_1();

               

            }
            else
            {

                playerAnimation.Attack_2();

             

            }

        }

    }
}
