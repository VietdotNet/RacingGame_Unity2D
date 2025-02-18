using UnityEngine;

public class Player1 : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Gán Rigidbody2D cho rb
        rb.gravityScale = 1f;             // Đảm bảo trọng lực hoạt động
    }

    void FixedUpdate()
    {
        // Lấy input trái-phải
        float moveX = Input.GetAxis("Horizontal");

        // Cách 1: Đặt thẳng velocity (phù hợp game 2D arcade)
        //rb.velocity = new Vector2(moveX * speed, rb.velocity.y);

        // (TÙY CHỌN) Cách 2: Thêm lực (phù hợp vật lý "trơn tru" hơn)
        rb.AddForce(new Vector2(moveX * speed, 0f));

        // Chỉ chọn một trong hai cách di chuyển ở trên.
        // Nếu bạn dùng cả hai cùng lúc, xe sẽ tăng tốc rất nhanh hoặc gặp xung đột.
    }
}
