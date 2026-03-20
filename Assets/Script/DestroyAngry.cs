using UnityEngine;

public class DestroyAngry : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("ระยะเวลาก่อนที่เอฟเฟกต์จะถูกลบ (วินาที)")]
    public float lifetime = 1.0f; 

    void Start()
    {
        // ทำลาย Object นี้ทิ้ง หลังจากเวลาผ่านไปตามที่ตั้งไว้ใน lifetime
        Destroy(gameObject, lifetime);
    }
}