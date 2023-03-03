using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Look : MonoBehaviour
{
    public GameObject _player;

    public Camera _viewCamera;

    public float cameraOffset;

    public float cameraZOffset;

    // Start is called before the first frame update
    void Start()
    {
        _viewCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        CameraFollowScript();
    }

    public void CameraFollowScript()
    {
        var charposX = _player.transform.position.x;
        var charposZ = _player.transform.position.z;
        //cameraOffset = 7f;
        //var cameraZOffset = 5f;
        _viewCamera.transform.position = new Vector3(charposX, cameraOffset, charposZ - cameraZOffset);
    }
}