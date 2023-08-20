using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearCokeCan : Projectile
{
    protected static Vector3 moveVector = new Vector3(2.5f, 0, 0);
    //protected static Vector2 attackOffset = new Vector2(0.5f, 0);
    protected static Sprite currSprite = Resources.Load<Sprite>("cokeBottle");
    LinearCokeCan(float posx, float posy, bool direction, GameObject gameObject, Vector2 attackOffset){
        this.gameObject.tag = "Enemy";

        if (direction){
            posx += attackOffset.x;
            posy += attackOffset.y;
        }
        else{
            posx -= attackOffset.x;
            posy -= attackOffset.y;
        }
        this.posx = posx;
        this.posy = posy;


        this.direction = direction;
        this.gameObject.transform.position = new Vector3(posx, posy, 0);
        this.spriteRenderer = this.gameObject.AddComponent<SpriteRenderer>();
        this.sprite = currSprite;
        this.spriteRenderer.sprite = this.sprite;
        this.range = 2;
        this.projectileCollision = this.gameObject.AddComponent<BoxCollider2D>();
        this.projectileCollision.isTrigger = true;
    }
    public void initLinearCokeCan(float posx, float posy, bool direction, Vector2 attackOffset){
        this.gameObject.tag = "Enemy";

        if (direction){
            posx += attackOffset.x;
            posy += attackOffset.y;
        }
        else{
            posx -= attackOffset.x;
            posy -= attackOffset.y;
        }
        this.posx = posx;
        this.posy = posy;


        this.direction = direction;
        this.gameObject.transform.position = new Vector3(posx, posy, 0);
        this.spriteRenderer = this.gameObject.AddComponent<SpriteRenderer>();
        this.sprite = currSprite;
        this.spriteRenderer.sprite = this.sprite;
        this.range = 3;
        this.projectileCollision = this.gameObject.AddComponent<BoxCollider2D>();
        this.projectileCollision.isTrigger = true;

        //rigidbodyTest
        this.projectileBody = this.gameObject.AddComponent<Rigidbody2D>();
        this.projectileBody.gravityScale = 0;
        this.projectileBody.freezeRotation = true;
        this.enemyProjectile = true;
        if (direction){
            this.projectileBody.velocity = moveVector;
        }
        else{
            this.projectileBody.velocity = moveVector * -1;
        }
    }
    public override Vector3 nextMoveVector(){
        return moveVector;
    }
}
