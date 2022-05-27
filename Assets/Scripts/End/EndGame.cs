using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    void Start()
    {
        Cursor.visible = false;
        StartCoroutine(InvokeDialogue());
    }

    void Update()
    {
        StartCoroutine(InvokeMenu());
    }

    private IEnumerator InvokeDialogue() 
    {
        yield return new WaitForSeconds(0.2f);

        DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
        StartCoroutine(InvokeMenu());
    }

    private IEnumerator InvokeMenu() 
    {   
        yield return new WaitForSeconds(0.3f);

        if (DialogueManager.GetInstance().dialogueIsPlaying == false) 
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
