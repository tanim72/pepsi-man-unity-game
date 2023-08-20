using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingCokeCan : Projectile
{
    // Start is called before the first frame update
    static Vector3 moveVector = new Vector3(5, 0, 0);
    static Sprite currSprite = Resources.Load<Sprite>("cokeThrowerPlaceholder.png");
    public void initLinearCokeCan(float posx, float posy, bool direction){
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
