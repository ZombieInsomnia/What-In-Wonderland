using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class DialogueLine
{
    public DialogueCharacter character;
    [TextArea (3, 10)]
    public string line;
}
[System.Serializable]
    public class DialogueCharacter
    {
      public string Name;
      public Sprite icon;
    }
[System.Serializable]
 public class DialogueTrigger 
{
    public List<DialogueLine> dialogueLines = new List<DialogueLine>();
}
[CreateAssetMenu(fileName = "NewDialogue", menuName = "Dialogue")]
public class Dialogue : ScriptableObject
{
    public DialogueTrigger dialogue;



    public void TriggerDialogue()
    {
        Debug.Log("TriggerDialogue");
        DialogueManager.instance.StartDialogue(dialogue);
        //calls the dialoguemanager start dialogue function
    }
}

