using UnityEngine;

public class RotateSkybox : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    private void FixedUpdate()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * _rotationSpeed);
    }
}