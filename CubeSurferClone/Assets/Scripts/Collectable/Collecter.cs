using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecter : MonoBehaviour
{
    public CollectablCube collectablcube;
    public GameObject playerCube;
    int cubeHeight;
  

    void Update()
    {
        playerCube.transform.position = new Vector3(transform.position.x, cubeHeight + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -cubeHeight, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collect"))
        {
            cubeHeight += 1;
            collectablcube.Collected();
            collectablcube.IndexManage(cubeHeight);
            other.gameObject.transform.parent = playerCube.transform;
        }
    }
}
