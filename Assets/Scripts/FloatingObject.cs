using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingObject : MonoBehaviour
{
    public float floatDistance = 1.0f;  // 飄動距離
    public float floatSpeed = 1.0f;     // 飄動速度

    private Vector3 startPos;
    private float phaseOffset;          // 隨機相位偏移

    void Start()
    {
        // 記錄物件的起始位置
        startPos = transform.position;

        // 設定隨機的相位偏移值
        phaseOffset = Random.Range(0f, Mathf.PI * 2f);
    }

    void Update()
    {
        // 使用相位偏移值產生隨機的起始方向
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed + phaseOffset) * floatDistance;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}
