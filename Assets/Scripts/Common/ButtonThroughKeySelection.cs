using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonThroughKeySelection : MonoBehaviour
{
    public string key;
    private Button button;
    private GameObject selectedButton;

    void Awake()
    {
        button = GetComponent<Button>();
    }

    void Update()
    {
        selectedButton = EventSystem.current.currentSelectedGameObject;

        if (Input.GetKeyDown(key) && (button.name == selectedButton.name))
        {
            button.onClick.Invoke();
        }
    }
}
