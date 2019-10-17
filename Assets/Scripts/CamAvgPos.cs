using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamAvgPos : MonoBehaviour
{
    public List<GameObject> ObjectsToConsider;

    public GameObject CamGameObject;

    // Update is called once per frame
    void Update()
    {
        float avgX = 0f;
        float avgY = 0f;

        foreach (var go in ObjectsToConsider)
        {
            avgX += go.transform.position.x;
            avgY += go.transform.position.y;
        }

        avgX /= ObjectsToConsider.Count;
        avgY /= ObjectsToConsider.Count;

        float z = CamGameObject.transform.position.z;
        CamGameObject.transform.position = new Vector3(avgX, avgY, z);
    }
}
