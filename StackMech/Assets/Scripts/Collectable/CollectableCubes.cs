using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCubes : MonoBehaviour
{
    bool isCollect;
    int index;
    public Collecter collecter;
    void Start()
    {
        isCollect = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCollect == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle")) {
            
            collecter.heightDecrease();
            // transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;

         }
    }

    public bool GetIsCollect()
    {
        return isCollect;
    }
    public void Collected()
    {
        isCollect = true;
    }

    public void IndexManager(int index)
    {
        this.index = index;
    }
}
