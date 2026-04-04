using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlannetTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SpaceCraft")
        {
            GameStateManager.Instance.SetState(GameStateManager.GameState.Lose);
        }
    }
}
