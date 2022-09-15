using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecter : MonoBehaviour
{
    GameObject player;
    int cubeHeight;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        player.transform.position = new Vector3(transform.position.x, cubeHeight + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -cubeHeight, 0);
    }

    public void heightDecrease()
    {
        cubeHeight--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable") && other.gameObject.GetComponent<CollectableCubes>().GetIsCollect() == false)
        {
            cubeHeight += 1;
            other.gameObject.GetComponent<CollectableCubes>().Collected();
            other.gameObject.GetComponent<CollectableCubes>().IndexManager(cubeHeight);
            other.gameObject.transform.parent = player.transform;
        }
    }
}
