using UnityEngine;

namespace FSM
{
    /// <summary> 
    /// ���� ������(�) ���������� � �������� �� ��������� �������
    /// </summary>
    public class IsObjectsInTriggerTransit : Transition
    {
        [SerializeField] private GameObject[] _objects;
        [SerializeField] private bool _invertLogic;

        private void Update()
        {
            
                




            foreach (var gameobject in _objects)//���������� �� �������
                if (_trigger.IsGameobjectInTrigger(gameobject) != _invertLogic)
                    NeedTransit = true;
        }
    }
}