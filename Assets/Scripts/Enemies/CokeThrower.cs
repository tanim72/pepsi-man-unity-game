using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CokeThrower : Enemy
{
    static Sprite currSprite = Resources.Load<Sprite>("enemy1Placeholder");
    CokeThrower(float posx, float posy, GameObject gameObject){
        Debug.Log("init coke thrower");

        this.gameObject.tag = "Enemy";
        this.posx = posx;
        this.posy = posy;
        this.gameObject.transform.position = new Vector3(posx, posy, 0);
        
        this.hp = 1;
        this.attackDelay = 1.5f;
        this.projectileNum = 10;
        this.projectiles = new GameObject[this.projectileNum];
        this.projectileType = "linearCokeCan";

        //sprite stuff
        this.sprite = currSprite;
        this.spriteRenderer = this.gameObject.AddComponent<SpriteRenderer>();
        this.spriteRenderer.sprite = this.sprite;

        this.boxCollider = this.gameObject.AddComponent<BoxCollider2D>();
        this.boxCollider.isTrigger = true;
        this.currAttack = attackDelay;
    }

    public void initCokeThrower(float posx, float posy){
        Debug.Log("init coke thrower");

        this.gameObject.tag = "Enemy";
        this.posx = posx;
        this.posy = posy;
        this.gameObject.transform.position = new Vector3(posx, posy, 0);

        this.hp = 1;
        this.attackDelay = 1.5f;
        this.projectileNum = 10;
        //this.projectiles = new GameObject[this.projectileNum];
        this.projectileType = "linearCokeCan";

        //sprite stuff
        this.sprite = currSprite;
        this.spriteRenderer = this.gameObject.AddComponent<SpriteRenderer>();
        this.spriteRenderer.sprite = this.sprite;

        this.boxCollider = this.gameObject.AddComponent<BoxCollider2D>();
        this.boxCollider.isTrigger = true;

        this.currAttack = attackDelay;
        this.attackOffset = new Vector2(0.5f, 0);

        this.enabled = true;

        this.enableDistance = 8;
    }
}
