using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialDialogue : MonoBehaviour
{
    
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    void Start()
    {
        StartCoroutine(InvokeDialogue());
        Cursor.visible = false;
        Time.timeScale = 1;
    }

    private IEnumerator InvokeDialogue() 
    {
        yield return new WaitForSeconds(0.2f);

        DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
    }
}
