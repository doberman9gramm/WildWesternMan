using UnityEngine;

public class RotateSkybox : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * _rotationSpeed);
    }
}