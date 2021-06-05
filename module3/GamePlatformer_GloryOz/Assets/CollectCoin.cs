using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    void onTriggerEnter(Collider other)
    {
        ScoringSystem.theScore += 50;
        Destroy(gameObject);
    }
}
