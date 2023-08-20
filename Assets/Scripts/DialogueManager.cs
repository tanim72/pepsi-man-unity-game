using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    private Queue<string> names;
    

    public Text nameText;
    public Text dialogueText;
    public Animator animator;
    public PlayerInteraction playerInteraction;

    void Start()
    {
        animator.SetBool("isOpen", false);
        sentences = new Queue<string>();
        sentences.Enqueue("1");
        sentences.Enqueue("2");
        names = new Queue<string>();
    }

    public bool isOpen(){
        return animator.GetBool("isOpen");
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("isOpen", true);
        sentences.Clear();
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        foreach(string name in dialogue.names)
        {
            names.Enqueue(name);
        }
        DisplayNextSentence(dialogue);
    }

    public void DisplayNextSentence(Dialogue dialogue)
    {
        
        if(sentences.Count == 0)
        {
            EndDialogue();
            // playerInteraction.setSpoken(true);
            return;
        }
        nameText.text = names.Dequeue();
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        // dialogueText.text = sentence;
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    
    void EndDialogue()
    {
        playerInteraction.setSpoken(true);
        animator.SetBool("isOpen", false);
        sentences.Enqueue("1");
        sentences.Enqueue("2");
    }
}
