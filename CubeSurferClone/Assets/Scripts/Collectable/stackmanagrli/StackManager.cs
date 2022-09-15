using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    public static StackManager instance;

    [SerializeField] private float distanceBetweenObjects;
    [SerializeField] private Transform prevObject;
    [SerializeField] private Transform parent;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        distanceBetweenObjects = prevObject.localScale.y;
    }

    public void PickUp(GameObject pickedObject, bool needTag = false, string tag = null, bool down = false)
    {
        if (needTag)
        {
            pickedObject.tag = tag;
        }

        pickedObject.transform.parent = parent;
        Vector3 desPos = prevObject.localPosition;
        desPos.y += down ? distanceBetweenObjects : -distanceBetweenObjects;
        pickedObject.transform.localPosition = desPos;
        prevObject = pickedObject.transform;
    }
}
