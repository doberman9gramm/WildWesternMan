using UnityEngine;

public class DontDestroyOnLoadGameObject : MonoBehaviour
{
    private void Awake() => DontDestroyOnLoad(gameObject);
}