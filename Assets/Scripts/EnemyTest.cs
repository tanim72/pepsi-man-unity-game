using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : Enemy
{
    // Start is called before the first frame update
    static Sprite currSprite = Resources.Load<Sprite>("enemy1Placeholder");
    public EnemyTest(float posx, float posy){
        this.posx = posx;
        this.posy = posy;
        this.hp = 1;
        this.attackDelay = 0.5f;
        this.projectileNum = 10;
        this.projectiles = new GameObject[this.projectileNum];
        //this.enemyCollision = this.gameObject.AddComponent<Rigidbody2D>();

        //sprite stuff

        this.sprite = Resources.Load<Sprite>("enemy1Placeholder");
        this.spriteRenderer = this.gameObject.AddComponent<SpriteRenderer>();
        this.spriteRenderer.sprite = this.sprite;

        this.boxCollider = this.gameObject.AddComponent<BoxCollider2D>();
        this.currAttack = attackDelay;
    }

    //test

    //test init method instead
    public void initEnemyTest(float posx, float posy){
        this.gameObject.tag = "Enemy";
        this.posx = posx;
        this.posy = posy;
        this.hp = 1;
        this.attackDelay = 1.5f;
        this.projectileNum = 10;
        this.projectiles = new GameObject[this.projectileNum];
        this.projectileType = "projectileTest";
        //this.enemyCollision = this.gameObject.AddComponent<Rigidbody2D>();

        //sprite stuff

        //this.sprite = Resources.Load<Sprite>("enemy1Placeholder");
        this.sprite = currSprite;
        this.spriteRenderer = this.gameObject.AddComponent<SpriteRenderer>();
        this.spriteRenderer.sprite = this.sprite;

        this.boxCollider = this.gameObject.AddComponent<BoxCollider2D>();
        //test
        this.gameObject.AddComponent<Rigidbody2D>();

        this.boxCollider.isTrigger = true;
        this.currAttack = attackDelay;
    }
}
