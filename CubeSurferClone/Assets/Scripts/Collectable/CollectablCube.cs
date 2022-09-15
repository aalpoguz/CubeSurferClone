using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablCube : MonoBehaviour
{
    bool isCollect;
    int index; //toplananın yüksekliğini belirtecek
    
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
                transform.localPosition = new Vector3 (0,-index,0);
            }
        }

    }

    public bool GetisCollect()
    {
        return isCollect;
    }

    public void Collected()
    {
        isCollect = true;
    }

    public void IndexManage(int index)
    {
        this.index = index;
    }
}
