using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextVisibility : MonoBehaviour
{
    //public TextMeshProUGUI textMeshProText;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering object has the tag "LeftHand" or "RightHand"
        if (other.CompareTag("LeftHand") || other.CompareTag("RightHand"))
        {
            // Set text visibility to true
            SetTextVisibility(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the exiting object has the tag "LeftHand" or "RightHand"
        if (other.CompareTag("LeftHand") || other.CompareTag("RightHand"))
        {
            // Set text visibility to false
            SetTextVisibility(false);
        }
    }

    private void SetTextVisibility(bool isVisible)
    {
        // Set the TextMeshPro text visibility based on the boolean value
        /*
        if (textMeshProText != null)
        {
            textMeshProText.gameObject.SetActive(isVisible);
        }
        */
    }
}


