using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    //� ������� �� �������
    //����� �������� 
    //���� ����������� ������
    //����� ���������, ����� ���� ��������

    public void Shoot()
    {
        Debug.Log("Shoot");
    }

    private void Reload()
    {
        Debug.Log("Reload");
    }
}