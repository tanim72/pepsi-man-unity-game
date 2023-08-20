using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTest : Projectile
{
    static Vector3 moveVector = new Vector3(5, 0, 0);
    static Sprite currSprite = Resources.Load<Sprite>("enemy1Placeholder");
    public ProjectileTest(float posx, float posy){
        Debug.Log("creating new testprojectile");
        this.posx = posx;
        this.posy = posy;
        //init rigidbody
        this.gameObject.transform.position = new Vector3(posx, posy, 0);

        //sprite stuff
        /*this.texture = new Texture2D(10,2);
        this.texture.LoadImage((Resources.Load("/enemy1Placeholder.png") as TextAsset).bytes);*/
        this.spriteRenderer = this.gameObject.AddComponent<SpriteRenderer>();
        this.sprite = Resources.Load<Sprite>("enemy1Placeholder");
        this.spriteRenderer.sprite = this.sprite;

        this.projectileCollision = this.gameObject.AddComponent<BoxCollider2D>();
    }
    //init test
    public void initProjectileTest(float posx, float posy, bool direction){
        this.gameObject.tag = "Enemy";
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

    public override Vector3 nextMoveVector(){
        return moveVector;
    }
}
