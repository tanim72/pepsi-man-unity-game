using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public float posx;
    public float posy;
    public int hp;
    protected float attackDelay;
    protected float currAttack;
    public bool alive = true;
    //if enemy in range of camera, become active
    public bool active = true;
    public bool currActive = true;
    protected int projectileNum;
    protected GameObject[] projectiles;
    public BoxCollider2D boxCollider;
    //public Rigidbody2D enemyCollision;
    //protected Sprite sprite;
    protected Sprite sprite;
    //protected Sprite enemySprite;
    protected SpriteRenderer spriteRenderer;
    protected string projectileType;
    //public bool active;
    public Vector3 playerPos;
    protected Vector2 attackOffset;
    //protected Vector2 attackOffset;
    protected int enableDistance;
    public void getPlayerPos(){
        this.playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
    }
    public void deleteEnemy(){
        Destroy(gameObject);
    }
    public void createProjectile(){
        //curr only using ProjectileTest
        currAttack -= Time.deltaTime;
        /*if (currAttack <= 0){
            //spawn projectile
            for (int i = 0; i < projectiles.Length; i++){
                if (projectiles[i] == null){
                    projectiles[i] = new GameObject();
                    if (projectileType == "projectileTest"){
                        projectiles[i].AddComponent<ProjectileTest>().initProjectileTest(posx, posy, playerPos.x > posx, projectiles[i]);
                    }
                    else if (projectileType == "linearCokeCan"){
                        //projectiles[i].AddComponent<LinearCokeCan>().initLinearCokeCan(posx, posy, playerPos.x >posx, projectiles[i]);
                        
                        projectiles[i].AddComponent<LinearCokeCan>().initLinearCokeCan(posx, posy, playerPos.x > posx, projectiles[i], attackOffset);
                        
                    }
                    break;
                }
            }
            //check for time later
            currAttack = attackDelay;
        }*/

        //TEST VERSION
        if (currAttack <= 0){
            //spawn projectile
            GameObject newProjectile = new GameObject();
            if (projectileType == "projectileTest"){
                newProjectile.AddComponent<ProjectileTest>().initProjectileTest(posx, posy, playerPos.x > posx);
            }
            else if (projectileType == "linearCokeCan"){
                newProjectile.AddComponent<LinearCokeCan>().initLinearCokeCan(posx, posy, playerPos.x > posx, attackOffset);
            }
            //check for time later
            currAttack = attackDelay;
        }
    }
    void Awake(){
        currActive = true;
        currAttack = 0;
    }
    void Update(){
        getPlayerPos();
        if (hp == 0){
            deleteEnemy();
        }
        if (currActive){
            //Debug.Log("currently active");
            createProjectile();
            //Debug.Log("posx + enable distance: " + (posx + enableDistance) + " posx - enableDistance: " + (posx - enableDistance) + " player x: " + playerPos.x);
            if (!(posx + enableDistance >= playerPos.x && posx - enableDistance <= playerPos.x)){
                //Debug.Log("Not in range");
                currActive = false;
            }
        }
        else if (posx + enableDistance >= playerPos.x && posx - enableDistance <= playerPos.x){
            //Debug.Log("now activated");
            currActive = true;
        }
        else{
        
        }
    }
    /*void OnTriggerEnter2D(Collider2D collider){
        if (collider.tag == "playerProjectile"){
            hp--;
        }
    }*/
    void FixedUpdate(){
        //Debug.Log("AAAA");
        /*getPlayerPos();
        if (hp == 0){
            deleteEnemy();
        }
        createProjectile();*/


        //Debug.Log(Mathf.Abs(playerPos.x - posx));
        
        /*if (active){
            Debug.Log("enabled");
            if (Mathf.Abs(playerPos.x - posx) >= enableDistance){
                Debug.Log("disabled");
                active = false;
            }
            createProjectile();
        }
        else if (Mathf.Abs(playerPos.x - posx) <= enableDistance){
            Debug.Log("becoming enabled");
            active = true;
        }*/
    }
    //void 
    
}
