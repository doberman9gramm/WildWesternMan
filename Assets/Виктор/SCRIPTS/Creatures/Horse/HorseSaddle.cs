using System;
using UnityEngine;

public class HorseSaddle : MonoBehaviour
{
    public Action<bool> IsSaddle;

    [SerializeField] private Horse _horse;
    [SerializeField] private Vector3 _saddleOffset;
    [SerializeField] private Vector3 _standOffset;

    private Transform _humanoideParent;

    /// <summary> ќседлать лошадь </summary>
    public void SaddleHorse(Humanoide humanoide, SaddleCondition saddleCondition)
    {
        if (saddleCondition == SaddleCondition.Saddle)
        {
            _humanoideParent = humanoide.transform.parent;//—охранение родител€, чтобы можно было потом вернуть его когда слезем с лошади
            humanoide.transform.SetParent(_horse.transform);
            humanoide.transform.position = GetPositionRelativeRotation(_saddleOffset);
            humanoide.transform.rotation = _horse.transform.rotation;
            IsSaddle?.Invoke(true);
        }
        else
        {
            humanoide.transform.position = GetPositionRelativeRotation(_standOffset);
            humanoide?.transform.SetParent(_humanoideParent);
            IsSaddle?.Invoke(false);
        }
    }

    /// <summary> Reference https://clck.ru/36Hiq8 </summary>
    private Vector3 GetPositionRelativeRotation(Vector3 offset)
    {
        Quaternion rotation = Quaternion.Euler(0, transform.eulerAngles.y, 0);
        return offset - (rotation * offset - transform.position + offset);
    }

    public enum SaddleCondition 
    {
        Saddle,
        UnSaddle
    }

    private void OnDrawGizmos()
    {
        //Saddle sit position gizmos
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(GetPositionRelativeRotation(_saddleOffset), .1f);

        //Stand position gizmos
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(GetPositionRelativeRotation(_standOffset), .1f);
    }
}