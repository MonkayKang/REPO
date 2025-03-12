using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DataHolder : MonoBehaviour
{
    // Points required to open a certain door
    public int Door1maxCount = 2;
    public int Door2maxCount = 1;
    public int Door3maxCount = 2;
    public int Door4maxCount = 3;

    // The door counter
    public static int Door1Counter;
    public static int Door2Counter;
    public static int Door3Counter;
    public static int Door4Counter;

    // IS the door open?
    public static bool door1 = false;
    public static bool door2 = false;
    public static bool door3 = false;
    public static bool door4 = false;

    // The door itself
    public GameObject Door1Object;
    public GameObject Door2Object;
    public GameObject Door3Object;
    public GameObject Door4Object;

    // The UI text
    public GameObject Panel;
    public TextMeshProUGUI UIText;
    public string Text;

    // The Inventory Count
    public static int LeverCount = 0;
    public static int PressureCount = 0;

    public TextMeshProUGUI LeverText;
    public TextMeshProUGUI PressureText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UIText.text = Text;
        LeverText.text = LeverCount.ToString() + " / 4";
        PressureText.text = PressureCount.ToString() + " / 4";
        if (Door1Counter >= Door1maxCount)
        {
            Text = "Door 1 is Open!"; // text update
            Panel.SetActive(true); // Start Text
            StartCoroutine(TextDialogue()); // Start the text message
            door1 = true; // Its open
            Door1Counter = -500; // Prevents Text Looping (the player will NEVER reach positive again)
        }

        if (Door2Counter >= Door2maxCount)
        {
            Text = "Door 2 is Open!"; // text update
            Panel.SetActive(true); // Start Text
            StartCoroutine(TextDialogue()); // Start the text message
            door2 = true; // Its open
            Door2Counter = -500; // Prevents Text Looping (the player will NEVER reach positive again)
        }

        if (Door3Counter >= Door3maxCount)
        {
            Text = "Door 3 is Open!"; // text update
            Panel.SetActive(true); // Start Text
            StartCoroutine(TextDialogue()); // Start the text message
            door3 = true; // Its open
            Door3Counter = -500; // Prevents Text Looping (the player will NEVER reach positive again)
        }

        if (Door4Counter >= Door4maxCount)
        {
            Text = "Final Door is Open!"; // text update
            Panel.SetActive(true); // Start Text
            StartCoroutine(TextDialogue()); // Start the text message
            door4 = true; // Its open
            Door4Counter = -500; // Prevents Text Looping (the player will NEVER reach positive again)
        }

        if (door1)
        {
            Animator doorAnimator = Door1Object.GetComponent<Animator>(); // ANIMATION (AKA OPENING)
            if (doorAnimator != null)
            {
                doorAnimator.SetBool("isOpen", true);
            }
            else
            {
                Debug.LogWarning("Animator component not found on Door1Object!");
            }
        }

        if (door2)
        {
            Animator doorAnimator2 = Door2Object.GetComponent<Animator>();  // ANIMATION (AKA OPENING)
            if (doorAnimator2 != null)
            {
                doorAnimator2.SetBool("isOpen", true);
            }
            else
            {
                Debug.LogWarning("Animator component not found on Door1Object!");
            }
        }

        if (door3)
        {
            Animator doorAnimator3 = Door3Object.GetComponent<Animator>(); // ANIMATION (AKA OPENING)
            if (doorAnimator3 != null)
            {
                doorAnimator3.SetBool("isOpen", true);
            }
            else
            {
                Debug.LogWarning("Animator component not found on Door1Object!");
            }
        }

        if (door4)
        {
            Animator doorAnimator4 = Door4Object.GetComponent<Animator>(); // ANIMATION (AKA OPENING)
            if (doorAnimator4 != null)
            {
                doorAnimator4.SetBool("isOpen", true);
            }
            else
            {
                Debug.LogWarning("Animator component not found on Door1Object!");
            }
        }
    }

    IEnumerator TextDialogue()
    {

        yield return new WaitForSeconds(2f); // Wait 3 secounds
        Panel.SetActive(false); // Turn the text off

    }
}

