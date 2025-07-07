using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public Waypoint[] waypoints;
    private void Reset() => waypoints = GetComponentsInChildren<Waypoint>(); // Hàm đặc biệt trong Editor: tự động tìm tất cả các "Waypoint" con và đưa vào danh sách trên.
}
