using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneTimer : MonoBehaviour
{
    public float changeTime;
    public string sceneName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        changeTime -= Time.deltaTime;   
        if (changeTime <= 0)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
