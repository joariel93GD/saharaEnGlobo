using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNubes : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float boundaryLeft = default;
    [SerializeField] private float boundaryRight = default;
    [SerializeField] private float speed = default;

    [Header("References")]
    [SerializeField] private Transform nube = default;

    private void Update()
    {
        nube.Translate(new Vector3(Time.deltaTime * speed, 0));

        if (nube.position.x >= boundaryRight)
        {
            nube.position = new Vector3(boundaryLeft, nube.position.y);
        }
    }
}
