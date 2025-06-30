using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    protected override void Die()
    {
        base.Die(); // Luôn gọi hàm của lớp cha để chạy các chức năng chung.
        Debug.Log("Enemy died");
    }

}
