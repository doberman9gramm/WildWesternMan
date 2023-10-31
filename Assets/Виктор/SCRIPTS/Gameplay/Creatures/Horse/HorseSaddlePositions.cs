using UnityEngine;

public class HorseSaddlePositions : MonoBehaviour
{
    [SerializeField] private Vector3 _saddleOffset;
    [SerializeField] private Vector3 _standOffset;
    [SerializeField] private bool _itsSettledHorse;///доделать

    public Vector3 GetSitPosition => GetPositionRelativeRotation(_saddleOffset);
    public Vector3 GetStandPosition => GetPositionRelativeRotation(_standOffset);

    /// <summary> Reference https://clck.ru/36Hiq8 </summary>
    private Vector3 GetPositionRelativeRotation(Vector3 offset)
    {
        Quaternion rotation = Quaternion.Euler(0, transform.eulerAngles.y, 0);
        return offset - (rotation * offset - transform.position + offset);
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