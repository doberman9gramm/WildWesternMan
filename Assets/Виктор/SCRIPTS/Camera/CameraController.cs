using Cinemachine;
using UnityEngine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CameraController : MonoBehaviour
{
    //Сырой скрипт нуждается в доработке вращения, приближения и тп.
    private CinemachineVirtualCamera _cinemachineVirtualCamera;
    private CinemachineFramingTransposer _cinemachineFramingTransposer;

    [Header("Distance")]
    [SerializeField] float _minDistance = 0f;
    [SerializeField] float _maxDistance = 45f;

    [Header("Angle")]
    [SerializeField] float _minAngle = 0f;
    //[SerializeField] float _maxAngle = 45f;

    private void Awake()
    {
        _cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
        _cinemachineFramingTransposer = _cinemachineVirtualCamera.GetCinemachineComponent<CinemachineFramingTransposer>();
    }

    public void ChangeCameraDistance(float value)
    {
        //ChangeAngle(value);//Меняет угол камеры при приближении -> стоит сделать отдельно
        value += _cinemachineFramingTransposer.m_CameraDistance;

        if (value < _minDistance)
            value = _minDistance;

        if (value > _maxDistance)
            value = _maxDistance;

        _cinemachineFramingTransposer.m_CameraDistance = value;
    }

    private void ChangeAngle(float value)
    {
        value = transform.eulerAngles.x + value;

        if (value < _minAngle)
            value = _minAngle;

        if (value > _maxDistance)
            value = _maxDistance;

        transform.eulerAngles = new Vector3(value, 0 ,0);
    }
}