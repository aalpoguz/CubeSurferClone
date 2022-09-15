using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadscrp : MonoBehaviour
{
    public GameObject LoseScreen;

    public Movement movement;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            movement.forwardSpeed = 0;
            LoseScreen.SetActive(true);
            Debug.Log("YOU LOSEEE");
        }
    }
}
