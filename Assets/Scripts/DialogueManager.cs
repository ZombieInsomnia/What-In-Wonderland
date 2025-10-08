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
    public bool isDialogueActive = false;
    public float typingSpeed;
    public Dialogue startDialogue;
    List<DialogueLine> currentDialogue = new List<DialogueLine>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (instance == null)
            instance = this;
        StartDialogue(startDialogue);
    }
    void Update()
    {
        if (isDialogueActive == true)
        {
            Time.timeScale = 0f;
        }
        if (isDialogueActive == false)
        {
            Time.timeScale = 1f;
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        if (dialogueIndex >= dialogue.dialogueLines.Count)
        {
            Debug.Log($"No dialogue?????? - {dialogue.dialogueLines.Count}");

            //End of dialogue
            EndDialogue();
            //line.Clear();
            dialogueIndex = 0;
        }
        else
        {
            Debug.Log("Pls work");

            isDialogueActive = true;
            dialoguePanel.SetActive(true);
            currentDialogue = dialogue.dialogueLines;
            DisplayNextDialogueLine();
        }
    }
    public void DisplayNextDialogueLine()
    {
        if (dialogueIndex >= currentDialogue.Count)
        {
            //End of dialogue
            EndDialogue();
            //line.Clear();
            dialogueIndex = 0;
            return;
        }

        DialogueLine currentLine = currentDialogue[dialogueIndex];
        nameText.SetText(currentLine.Name);
        potraitImage.sprite = currentLine.icon;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(currentLine));
        dialogueIndex++;

    }
    IEnumerator TypeSentence(DialogueLine dialogueLine)
    {
        dialogueText.text = "";
        foreach (char letter in dialogueLine.line.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        yield return null;
    }
    public void EndDialogue()
    {
        isDialogueActive = false;
        dialoguePanel?.SetActive(false);
    }

  
}
