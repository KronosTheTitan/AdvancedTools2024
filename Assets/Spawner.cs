using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Setup")] [SerializeField] private int width;
    [SerializeField] private int height;
    [SerializeField] private int startingHeight;

    [SerializeField] private GameObject bouncingBall;

    [SerializeField] private Transform bouncingBallParent;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector3 position = (Vector3.right * x) + Vector3.up * startingHeight + (Vector3.forward * y);

                Instantiate(bouncingBall, position, Quaternion.identity, bouncingBallParent);
            }
        }
    }


    [Header("Gizmos")] [SerializeField] private float sphereSize = 1f;

    public void OnDrawGizmos()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector3 position = (Vector3.right * x) + Vector3.up + (Vector3.forward * y);

                Gizmos.DrawSphere(position, sphereSize);
            }
        }
    }
}