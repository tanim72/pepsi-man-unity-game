using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 fireOffset = new Vector2(1, 0);
    public float attackDelay = 0.5f;
    public float currAttack = 0;
    public Transform playerTransform;
    public CharacterController2D characterController;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currAttack += Time.deltaTime;
        if (Input.GetButtonDown("Fire1")){
            Debug.Log("attackign!");
            if(currAttack >= attackDelay){
                Debug.Log("attacking");
                //ATTACK!
                new GameObject().AddComponent<PlayerProjectile>().initPlayerProjectile(playerTransform.position.x, playerTransform.position.y, characterController.m_FacingRight, fireOffset);
                currAttack = 0;
            }
        }
    }
}
