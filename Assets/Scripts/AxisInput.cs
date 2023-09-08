using UnityEngine;

namespace InputNameSpace
{
    public class AxisInput
    {
        public static float Horizontal => Input.GetAxis(Axis.Horizontal);
        public static float Vertical => Input.GetAxis(Axis.Vertical);
    }
}