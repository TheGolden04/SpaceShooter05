using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Các biến từ cả 2 slide
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    private int healthPoint;

    private void Start()
    {
        healthPoint = defaultHealthPoint; // Gán giá trị máu hiện tại bằng giá trị máu ban đầu đã thiết lập.
    }

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) // Nếu đối tượng đã chết, thì không làm gì cả và thoát khỏi hàm.
        {
            return;
        }
        healthPoint -= damage; // Trừ đi lượng máu bằng với sát thương nhận vào.
        if (healthPoint <= 0) // Sau khi trừ máu, kiểm tra xem máu có xuống dưới hoặc bằng 0 không
        {
            Die(); // Nếu có, gọi hàm Die() để xử lý cái chết.
        }
    }

    // public void OnTriggerEnter2D(Collider2D collision) => Die(); Gây lỗi logic ở đây

    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation); // Tạo ra một bản sao của prefab hiệu ứng nổ.
        Destroy(explosion, 1); // Hủy đối tượng hiệu ứng nổ sau 1 giây, để nó có thời gian hiển thị.
        Destroy(gameObject); // Hủy chính đối tượng game object đang gắn script này
    }
}