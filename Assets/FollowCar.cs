using UnityEngine;

public class FollowCar : MonoBehaviour
{
    public Transform car; // Tham chiếu đến xe

    void Update()
    {
        if (car != null)
        {
            // Chỉ di chuyển Background theo trục X của xe
            transform.position = new Vector3(car.position.x, transform.position.y, transform.position.z);
        }
    }
}
