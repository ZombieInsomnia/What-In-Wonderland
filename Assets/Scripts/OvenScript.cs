using UnityEngine;
using UnityEngine.SceneManagement;

public class OvenScript : MonoBehaviour
    
{
    [SerializeField] InventoryManager inventoryManager;
    public bool hasBakingTray = false;
    public string sceneName;
    public Dialogue ovenDialogue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Oven()
    {
        if (hasBakingTray == true)
        {
            inventoryManager.QuestItemGiven();
            SceneManager.LoadScene(sceneName);
            Debug.Log("Play cutscene");
        }
        else
        {
            DialogueManager.instance.StartDialogue(ovenDialogue);
            Debug.Log("Nothing Happened");
        }
    }

    
}
