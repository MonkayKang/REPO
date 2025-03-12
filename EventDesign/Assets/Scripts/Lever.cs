using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    // All Levers
    public bool isLever1;
    public bool isLever2;
    public bool isLever3;

    // Can only be triggered once
    private bool isActivated = false;
    private bool isActivated2 = false;

    // The "animation" of the lever
    public GameObject leveropen;
    public GameObject leverclose;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && isLever1 && !isActivated) // Lever 1
        {
            DataHolder.Door1Counter++; // Add a point required to open the door
            DataHolder.LeverCount++; // Add a lever count
            leveropen.SetActive(false); // "Animation"
            leverclose.SetActive(true);
            isActivated = true; // Can only be activated once
        }

        if (collision.gameObject.CompareTag("Player") && isLever2 && !isActivated2)
        {
            DataHolder.Door2Counter++;  // Add a point required to open the door
            DataHolder.LeverCount++; // Add a lever count
            leveropen.SetActive(false); // "Animation"
            leverclose.SetActive(true);
            isActivated2 = true; // Can only be activated once
        }

        if (collision.gameObject.CompareTag("Player") && isLever3 && !isActivated)
        {
            DataHolder.Door4Counter++;
            DataHolder.LeverCount++; // Add a lever count
            leveropen.SetActive(false);
            leverclose.SetActive(true);
            isActivated2 = true; // Can only be activated once
        }
    }
}
