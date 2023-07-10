using UnityEngine;

public class Cms : MonoBehaviour
{
    public Camera mainCamera;

    void Start()
    {
        // Calculate the combined width of the screens /////////
        float combinedWidth = Display.displays.Length * Screen.width;

        // Set the viewport of the main camera to cover the combined width
        mainCamera.rect = new Rect(0f, 0f, combinedWidth / Screen.width, 1f);
    }
}
