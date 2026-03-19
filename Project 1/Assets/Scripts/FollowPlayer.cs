using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // This creates a reference to the player which we can set inside the Unity Editor.
    public GameObject player;
    private Vector3 cameraOffset = new Vector3(0, 7, -9);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // This sets the position of the camera to be the same as the player's position, but with an offset of 7 units up and 9 units back.
        transform.position = player.transform.position + cameraOffset;
    }
}
