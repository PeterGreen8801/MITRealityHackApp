using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DeactivateGrab : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
    private bool isOnSocket = false;

    void Awake()
    {
        // Get the XRGrabInteractable component on this GameObject
        grabInteractable = GetComponent<XRGrabInteractable>();

        // Subscribe to the OnSelectEntered and OnSelectExited events
        grabInteractable.selectEntered.AddListener(OnSelectEntered);
        grabInteractable.selectExited.AddListener(OnSelectExited);
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        // Check if the XRGrabInteractable is attached to a socket
        if (isOnSocket)
        {
            // Disable the XRGrabInteractable component when attached to a socket
            grabInteractable.enabled = false;

            // Optionally, deactivate the entire GameObject
            // gameObject.SetActive(false);
        }
    }

    private void OnSelectExited(SelectExitEventArgs args)
    {
        // Re-enable the XRGrabInteractable component when the player releases the object
        grabInteractable.enabled = true;
    }

    // Call this method when the tomato slice is placed on the socket
    public void SetOnSocket(bool onSocket)
    {
        isOnSocket = onSocket;
        if (onSocket)
        {
            // Disable the XRGrabInteractable component when attached to a socket
            grabInteractable.enabled = false;

            // Optionally, deactivate the entire GameObject
            // gameObject.SetActive(false);
        }
    }
}
