using UnityEngine;


public class Interaction : MonoBehaviour
{
    private void Update()
    {
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
            if (collider.TryGetComponent(out Intera component))
            {

            }
    }

    //������� ������� �� ������ ����� ������������� �� ����� ������
}