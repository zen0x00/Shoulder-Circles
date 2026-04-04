using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashZone : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SpaceShip")
        {
            // GameStateManager.Instance.SetState(GameStateManager.GameState.Lose);
            Debug.Log("hi");
        }
    }
}
