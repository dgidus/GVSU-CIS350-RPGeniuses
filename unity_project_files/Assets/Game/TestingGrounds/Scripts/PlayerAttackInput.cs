using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackInput : MonoBehaviour
{

    private CharacterAnimations playerAnimation;

    public GameObject attackPoint;

    // Start is called before the first frame update
    void Awake()
    {
        playerAnimation = GetComponent<CharacterAnimations>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            playerAnimation.Defend(true);
        }

        if(Input.GetKeyUp(KeyCode.J))
        {
            playerAnimation.Defend(false);
        }

        if(Input.GetKeyDown(KeyCode.K))
        {
            if(Random.Range(0,2) > 0)
            {
                playerAnimation.Attack_1();
            }else
            {
                playerAnimation.Attack_2();
            }
        }
    }

    void Activate_AttackPoint()
    {
        attackPoint.SetActive(true);
    }

    void Deactivate_AttackPoint()
    {
        if(attackPoint.activeInHierarchy)
        {
            attackPoint.SetActive(false);
        }
    }
}//class



















