using UnityEngine;

public class VFXManager : MonoBehaviour
{
    [Header("VFX Prefabs")]
    public GameObject angryVfxPrefab; 
    public GameObject smokePrefab; 
    public GameObject starPrefab; // <--- ช่องสำหรับลากดาวใส่

    // --- ฟังก์ชันสำหรับเรียกใช้ในเกม ---

    public void SpawnAngryVFX(Vector3 position)
    {
        if (angryVfxPrefab != null) Instantiate(angryVfxPrefab, position, Quaternion.identity);
    }

    public void SpawnSmoke(Vector3 position)
    {
        if (smokePrefab != null) Instantiate(smokePrefab, position, Quaternion.identity);
    }

    // ฟังก์ชันเรียกดาวหมุน
    public void SpawnStarDizzy(Vector3 position)
    {
        if (starPrefab != null)
        {
            Instantiate(starPrefab, position, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("ยังไม่ได้ลาก Prefab ดาวใส่ใน VFXManager!");
        }
    }

    // --- ส่วนของการทดสอบปุ่มกด ---
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) SpawnAngryVFX(transform.position + Vector3.up * 2f);
        if (Input.GetKeyDown(KeyCode.B)) SpawnSmoke(transform.position + Vector3.up * 1.5f);
        
        // กดปุ่ม N เพื่อทดสอบดาวหมุน
        if (Input.GetKeyDown(KeyCode.N)) 
        {
            SpawnStarDizzy(transform.position + Vector3.up * 2f);
        }
    }
}