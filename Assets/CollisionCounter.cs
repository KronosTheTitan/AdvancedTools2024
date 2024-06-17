using System;
using UnityEngine;

public class CollisionCounter : MonoBehaviour
{
    [SerializeField] private Logger logger;
    private void OnCollisionEnter(Collision other)
    {
        logger.AddCollision();
    }
}
