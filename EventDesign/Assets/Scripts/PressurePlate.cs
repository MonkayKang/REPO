using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    // Can only be activated once
    private bool isActivated = false;
    private bool isActivated2 = false;
    private bool isActivated3 = false;

    // the pressure plates
    public bool isPressure2;
    public bool isPressure3;

    // The final levers
    public GameObject LastLever1;
    public GameObject LastLever2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Box" && !isActivated) // Pressure plate 1
        {
            Debug.Log("Door1 is open"); // Testing
            DataHolder.Door1Counter ++; // Add a point require to open the door
            DataHolder.PressureCount++; // Add a count to pressure
            isActivated = true; // Activate only once
        }

        if (collision.gameObject.name == "Box2" && !isActivated2 && isPressure2) // Pressure plate 2
        {
            Debug.Log("PressurePlate Activated");
            DataHolder.Door3Counter++; // Add a point require to open the door
            DataHolder.PressureCount++; // Add a count to pressure
            isActivated2 = true; // Activate only once
        }

        if (collision.gameObject.name == "Box3" && !isActivated3 && isPressure3) // Pressure plate 3
        {
            Debug.Log("PressurePlate2 Activated");
            LastLever1.SetActive(true); LastLever2.SetActive(true);
            DataHolder.Door4Counter++; // Add a point require to open the door
            DataHolder.PressureCount++; // Add a count to pressure
            isActivated3 = true; // Activate only once
        }

        if (collision.gameObject.name == "Box22" && !isActivated3 && isPressure2) // Pressure plate 4
        {
            Debug.Log("PressurePlate2 Activated");
            LastLever1.SetActive(true); LastLever2.SetActive(true);
            DataHolder.Door3Counter++; // Add a point require to open the door
            DataHolder.PressureCount++; // Add a count to pressure
            isActivated3 = true; // Activate only once
        }
    }
}
