using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueManager DialogueManager;

    public void TriggerDialogue ()
    {
        if(DialogueManager.isOpen())
        {
            if(Input.GetKeyDown(KeyCode.Z))
            {
                FindObjectOfType<DialogueManager>().DisplayNextSentence(dialogue);
            }
        }
        else
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}