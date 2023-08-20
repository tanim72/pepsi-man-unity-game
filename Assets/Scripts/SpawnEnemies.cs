using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    // Start is called before the first frame update
    //GameObject[] enemies = new GameObject[10];
    void Awake()
    {
        /*enemies[0] = new GameObject();
        enemies[0].AddComponent<EnemyTest>();
        enemies[0].GetComponent<EnemyTest>().initEnemyTest(0, 0, enemies[0]);*/

        new GameObject().AddComponent<CokeThrower>().initCokeThrower(0, -0.52f);
        new GameObject().AddComponent<CokeThrower>().initCokeThrower(14.5f, -0.52f);
        new GameObject().AddComponent<CokeThrower>().initCokeThrower(21.5f, 1.5f);
        new GameObject().AddComponent<CokeThrower>().initCokeThrower(31.5f, 4.5f);
        new GameObject().AddComponent<CokeThrower>().initCokeThrower(48.5f, 5.5f);
        new GameObject().AddComponent<CokeThrower>().initCokeThrower(54f, 5.5f);
        new GameObject().AddComponent<CokeThrower>().initCokeThrower(62.5f, -0.5f);
        new GameObject().AddComponent<CokeThrower>().initCokeThrower(74f, 0.5f);
        new GameObject().AddComponent<CokeThrower>().initCokeThrower(85f, 3.5f);
        new GameObject().AddComponent<CokeThrower>().initCokeThrower(93f, 6.5f);
        new GameObject().AddComponent<CokeThrower>().initCokeThrower(96f, 6.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(1.0f / Time.deltaTime);
    }
}
