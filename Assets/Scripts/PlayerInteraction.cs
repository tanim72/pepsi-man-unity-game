using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject currentNPC = null;
    public DialogueManager DialogueManager;
    public bool hasSpoken = false;

    void Update()
    {
        if (currentNPC)
        {
            if (!hasSpoken)
            {
                currentNPC.SendMessage("TriggerDialogue");
            }

        }
    }

    public void setSpoken(bool spoken)
    {
        hasSpoken = spoken;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("NPC"))
        {
            currentNPC = other.gameObject;
        }
        /*else if (other.CompareTag("Enemy"))
        {
            //deal dmg
            Debug.Log("hit");
        }*/
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("NPC"))
            if (currentNPC = other.gameObject)
            {
                currentNPC = null;
                hasSpoken = false;
            }
    }
}
