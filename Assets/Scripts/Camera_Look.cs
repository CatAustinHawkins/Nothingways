using UnityEngine;

public class Camera_Look : MonoBehaviour
{
    public GameObject _player;

    public Camera _viewCamera;

    public float cameraOffset;

    public float cameraZOffset;

    void Start()
    {
        _viewCamera = Camera.main;
    }

    void Update()
    {
        CameraFollowScript();
    }

    public void CameraFollowScript()
    {
        var charposX = _player.transform.position.x;
        var charposZ = _player.transform.position.z;
        _viewCamera.transform.position = new Vector3(charposX, cameraOffset, charposZ - cameraZOffset);
    }
}