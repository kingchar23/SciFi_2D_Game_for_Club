using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private float minYPos;
    [SerializeField]
    private float maxYPos;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 vel = new Vector2(h * movementSpeed, v * movementSpeed);

        Vector3 pos = transform.position + vel * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minYPos, maxYPos);
        transform.position = pos;
    }
}
