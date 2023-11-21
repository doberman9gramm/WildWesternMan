using UnityEngine;

public class Toggle : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private ActiveSelf _active;

    public void ToggleGameObject()
    {
        _gameObject.SetActive(_active == ActiveSelf.Enabled);
    }

    public enum ActiveSelf
    {
        Enabled,
        Disabled
    }
}