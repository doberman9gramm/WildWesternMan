using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AgentInteractionGUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private GameObject _image;

    public void ShowIntecrationGUi(string text, Visibility visibility)
    {
        _text.text = text;
        _image.SetActive(Visibility.show == visibility);
    }

    public enum Visibility
    {
        show,
        hide
    }
}
