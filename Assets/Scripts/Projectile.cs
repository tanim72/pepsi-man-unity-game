using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    public float posx;
    public float posy;
    public void updateProjectile(){
        //check if projectile is colliding with player, update projectile position

    }
    //either do this or just have a vector3 with the move info?
    public abstract Vector3 nextMoveVector();
    public BoxCollider2D projectileCollision;

    //test rigidbody
    public Rigidbody2D projectileBody;

    //sprite stuff
    protected Sprite sprite;
    protected SpriteRenderer spriteRenderer;
    //remove self if time alive is above range
    protected float range;
    private float timeAlive = 0;
    //protected Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
    protected bool direction;
    protected bool enemyProjectile;

    //test abstract with behaviour stuff
    //public abstract void OnTriggerEnter2D(Collider2D collider);
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (enemyProjectile){
            //Debug.Log();
            if (collider.tag == "Player"){
                //todo, player take dmg
                deleteProjectile();
            }
        }
        else if (collider.tag == "Enemy"){
            collider.GetComponent<Enemy>().hp--;
            deleteProjectile();
        }
        Debug.Log("hit collider");
        Debug.Log(collider.tag);
    }

    public void deleteProjectile(){
        Destroy(gameObject);
    }
    void FixedUpdate(){
        timeAlive += Time.deltaTime;
        if (timeAlive >= range){
            Debug.Log("out of time");
            deleteProjectile();
        }

        /*Vector3 moveVector = nextMoveVector() * Time.deltaTime;
        if (!direction){
            moveVector.x *= -1;
        }
        this.gameObject.transform.position += moveVector;
        this.posx += (moveVector.x);
        this.posy += (moveVector.y);*/

        //TEST
    }
    void Update(){

    }

}
