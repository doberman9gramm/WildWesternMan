using System.Collections.Generic;
using UnityEngine;

namespace Railway
{
    [ExecuteAlways]
    public class RailwaySystem : MonoBehaviour
    {
        [SerializeField] private List<Railway> _railways;
        [SerializeField] private List<Vector3> _wayPoints;

        private void OnValidate()
        {
            _railways.Clear();

            foreach (var item in gameObject.GetComponentsInChildren<Railway>())
                _railways.Add(item);

            _wayPoints.Clear();

            _wayPoints = GetWayPoints(_railways);
        }

        private List<Vector3> GetWayPoints(List<Railway> railways)
        {
            List<Vector3> points = new List<Vector3>();
            //float distanceToCombiningPoints = .1f;

            for (int i = 0; i < railways.Count; i++)
            {
                Vector3 newStartPoint = railways[i].GetStart;
                //“ут ошибка логики, нужно сначала добавить первую точку и затем свер€€сь с ней объедин€ть остальные, а вообще 
                //надо посмотреть как объединение точек в blender сделано или на utube че тупить то
                /*foreach (Vector3 point in points)
                {
                    if (distanceToCombiningPoints < Vector3.Distance(point, newStartPoint))
                    {
                        points.Add(newStartPoint);
                    }
                }*/

                points.Add(railways[i].GetEnd);
            }

            return points;
        }
    }
}