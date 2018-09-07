using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [SerializeField]
    private Transform target;
    [SerializeField]
    private Vector3 offset;
    [SerializeField]
    private float smoothTime;
    [SerializeField]
    private float minYPos;
    [SerializeField]
    private float maxYPos;

    private Vector3 vel;

    private void Start()
    {
        if (!target)
            Debug.LogWarning("Camera has no target!");
    }

    private void Update()
    {
        if (!target) return;
        Vector3 pos = Vector3.SmoothDamp(transform.position, target.position + offset, ref vel, smoothTime);
        pos.y = Mathf.Clamp(pos.y, minYPos, maxYPos);
        transform.position = pos;
    }
}
