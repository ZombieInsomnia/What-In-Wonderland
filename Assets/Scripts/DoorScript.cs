using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public bool canLeave = false;
    public string sceneName;
    public Dialogue attemptDoor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Door()
    {
       
            Debug.Log("now's not the time");
            DialogueManager.instance.StartDialogue(attemptDoor);
       
    }

    public void DoorUnlock()
    {
       
        SceneManager.LoadScene(sceneName);
    }
}
