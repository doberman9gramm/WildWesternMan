using UnityEngine;

public class AnimationEventHeavyAttack : MonoBehaviour
{
    [SerializeField] private FreezeTransitionts _freezeTransitionts;

    /// <summary>
    /// ���������� �������� ���� �������� �� �����������
    /// </summary>
    private void SetFreeze(bool _isFreeze)
    {
        _freezeTransitionts.Freeze(_isFreeze);
    }

    public void Freeze() => SetFreeze(true);
    public void UnFreeze() => SetFreeze(false);
}
