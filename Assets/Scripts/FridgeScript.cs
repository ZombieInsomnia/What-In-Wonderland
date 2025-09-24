
using UnityEngine;

public class FridgeScript : MonoBehaviour
{
    [SerializeField] Canvas Fridge;
    
    
    void Start()
    {
        Fridge = GetComponent<Canvas>();    
        Fridge.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) 
        {
            Close();
        }
        
    }
   public void Open()
    {
        Fridge.enabled = true;
        Time.timeScale = 0f;
        Debug.Log("Yay");
    }
    public void Close()
    {
        Fridge.enabled = false;
        Time.timeScale = 1f;
    }
}
