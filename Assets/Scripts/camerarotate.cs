using UnityEngine;

public class camerarotate : MonoBehaviour
{
    public Transform camTarget;
    public float pLerp = .01f;
    public float rLerp = .02f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, camTarget.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, camTarget.rotation, rLerp);
    }
}

