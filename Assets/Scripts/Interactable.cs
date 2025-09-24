using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool inRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    
    [SerializeField] TextMeshProUGUI interactiveText;
    void Start()
    {
       
        interactiveText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
                  //sets the unity event off that's set in the inspector

            }
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            inRange = true;
            interactiveText.enabled = true;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        inRange = false;                          
        interactiveText.enabled = false;    
    }
}
