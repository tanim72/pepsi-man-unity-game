using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CokeDispenser : Enemy
{
    static Sprite currSprite = Resources.Load<Sprite>("cokeThrowerPlaceholder");

    CokeDispenser(float posx, float posy){

        this.gameObject.tag = "Enemy";
        this.posx = posx;
        this.posy = posy;
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

    public void initCokeDispenser(float posx, float posy){
        this.gameObject.tag = "Enemy";
        this.posx = posx;
        this.posy = posy;
        this.hp = 1;
        this.attackDelay = 1.5f;
        this.projectileNum = 10;
        this.projectiles = new GameObject[this.projectileNum];
        this.projectileType = "rollingCokeCan";

        //sprite stuff
        this.sprite = currSprite;
        this.spriteRenderer = this.gameObject.AddComponent<SpriteRenderer>();
        this.spriteRenderer.sprite = this.sprite;

        this.boxCollider = this.gameObject.AddComponent<BoxCollider2D>();
        this.boxCollider.isTrigger = true;
        this.currAttack = attackDelay;
        this.attackOffset = new Vector2(1, 0);
    }
}
