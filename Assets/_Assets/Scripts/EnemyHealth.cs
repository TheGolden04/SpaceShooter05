using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    public static int LivingEnemyCount; // Biến 'static' để đếm chung số lượng kẻ địch đang sống cho toàn bộ màn chơi.
    private void Awake()
    {
        LivingEnemyCount++; // Khi kẻ địch được tạo, tăng tổng số kẻ địch lên 1 (hàm Awake() tự động chạy).
    }
    protected override void Die()
    {
        LivingEnemyCount--;
        base.Die(); // Luôn gọi hàm của lớp cha để chạy các chức năng chung.
        Debug.Log("Enemy died");
    }
}
