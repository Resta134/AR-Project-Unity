using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    public float rotateSpeed = 0.5f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.Rotate(
                    0,
                    -touch.deltaPosition.x * rotateSpeed,
                    0
                );
            }
        }
    }
}