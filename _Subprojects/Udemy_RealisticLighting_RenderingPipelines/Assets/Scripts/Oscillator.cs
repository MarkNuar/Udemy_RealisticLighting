using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] private Vector3 directionMultiplier;
    [SerializeField] private float frequencyMultiplier = 1f;


    // Update is called once per frame
    void Update()
    {
        float xOffset = directionMultiplier.x * Mathf.Sin(frequencyMultiplier * Time.time);
        float yOffset = directionMultiplier.y * Mathf.Sin(frequencyMultiplier * Time.time);
        float zOffset = directionMultiplier.z * Mathf.Sin(frequencyMultiplier * Time.time);
        transform.position += new Vector3(xOffset, yOffset, zOffset);

    }
}
