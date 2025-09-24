using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText, nameText;
    public Image potraitImage;
    int dialogueIndex;
    public static DialogueManager instance;
    private Queue<DialogueLine> lines;
    public bool isDialogueActive = false;
    public float typingSpeed = 0.2f;
    DialogueCharacter character;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (instance == null)
            instance = this;
    }

    public void StartDialogue(DialogueTrigger dialogue)
    {
        Debug.Log("Pls work");
        
        isDialogueActive = true; 
        dialoguePanel.SetActive(true);
        lines.Clear(); //clears dialogue queue in case there is any lines left over (adding this causes the same error)

        Debug.Log("why won't u work"); //this doesn't show up anymore
        foreach (DialogueLine dialogueLine in dialogue.dialogueLines) //supposed to go through the dialogue lines
        { 
            lines.Enqueue(dialogueLine);
            Debug.Log("pls pls pls"); 
        }
        DisplayNextDialogueLine();
    }
    public void DisplayNextDialogueLine()
    {
        if (lines.Count == 0)
        {
            EndDialogue();
            return;
        }
        DialogueLine currentLine = lines.Dequeue();
        nameText.SetText(character.Name);
        potraitImage.sprite = character.icon;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(currentLine));

    }
    IEnumerator TypeSentence(DialogueLine dialogueLine)
    {
        dialogueText.text = "";
        foreach (char letter in dialogueLine.line.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    public void EndDialogue()
    {
        isDialogueActive = false;
        dialoguePanel?.SetActive(false);
    }

  
}
