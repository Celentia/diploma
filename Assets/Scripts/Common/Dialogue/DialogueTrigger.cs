using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    
    [Tooltip("Defines if dialog should be triggered once per game")]
    public bool isTriggeredOnce = false;

    private bool playerInRange;
    private bool isTriggered = false; 
    private bool isAnswered = false;

    private void Awake() 
    {
        playerInRange = false;
    }

    private void Update() 
    {
        foreach (string item in DialogueManager.GetInstance().list) 
        {
            if (item == gameObject.name) 
            {
                isAnswered = true;
            }
        }
        if (playerInRange && isTriggered == false && !DialogueManager.GetInstance().dialogueIsPlaying && !isAnswered)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                if (isTriggeredOnce) {
                    isTriggered = true;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider collider) 
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }
}
