using UnityEngine;
using PlayerSpace;

public class Horse : MonoBehaviour
{
    [SerializeField] private Vector3 _sitPosition;
    /*[SerializeField] private Player _player;
    [SerializeField] private ObjectInTrigger _checkerCurrentObjectInTrigger;

    private void Awake()
    {
        _checkerCurrentObjectInTrigger = GetComponent<ObjectInTrigger>();
        _checkerCurrentObjectInTrigger.Initialization(_player);
    }

    private void OnEnable()
    {
        _checkerCurrentObjectInTrigger.ObjectEnter += PlayerManipulations;
    }

    private void OnDisable()
    {
        _checkerCurrentObjectInTrigger.ObjectEnter -= PlayerManipulations;
    }

    private void PlayerManipulations(Collider collider)
    {
        _player = GetPlayer(collider);
        AddChild(_player.gameObject);
        _player.transform.position = _sitPosition + transform.position;
    }

    private Player GetPlayer(Collider collider) => collider.GetComponent<Player>();

    private void AddChild(GameObject child) => child.transform.parent = gameObject.transform;
*/
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(_sitPosition + transform.position, .1f);
    }
}