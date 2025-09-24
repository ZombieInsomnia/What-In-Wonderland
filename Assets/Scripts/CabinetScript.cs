using UnityEngine;

public class CabinetScript : MonoBehaviour
{
    [SerializeField] Canvas Cabinet;


    void Start()
    {
        Cabinet = GetComponent<Canvas>();
        Cabinet.enabled = false;
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
        Cabinet.enabled = true;
        Time.timeScale = 0f;
        
    }
    public void Close()
    {
        Cabinet.enabled = false;
        Time.timeScale = 1f;
    }
}
