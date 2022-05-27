using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalUnlock : MonoBehaviour
{
    public GameObject PortalParticles;
    private bool questionsAreAnswered = false;
    private const int totalAnswerNumber = 5;

    void Update()
    {
        if (DialogueManager.GetInstance().answerCounter == totalAnswerNumber) 
        {
            PortalParticles.SetActive(true);
            questionsAreAnswered = true;
        }
        else 
        {
            PortalParticles.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (questionsAreAnswered) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
