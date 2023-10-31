using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;

namespace HorseSpace
{
    public class AgentSitOnMeTransition : Transition
    {
        [SerializeField] private HorseSaddlePositions _horseSaddlePositions;
    }
}