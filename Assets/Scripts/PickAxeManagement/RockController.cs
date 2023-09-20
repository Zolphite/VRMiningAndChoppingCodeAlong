using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    public GameObject shatteredRock; // Assign a pre-fractured rock model

    public void BreakRock()
    {
        shatteredRock.SetActive(true);
        gameObject.SetActive(false);
        // You could also add more effects like sounds, particles, etc.
    }
}
