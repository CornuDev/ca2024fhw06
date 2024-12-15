using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingObject : MonoBehaviour
{
    public float floatDistance = 1.0f;  // �ưʶZ��
    public float floatSpeed = 1.0f;     // �ưʳt��

    private Vector3 startPos;
    private float phaseOffset;          // �H���ۦ찾��

    void Start()
    {
        // �O�����󪺰_�l��m
        startPos = transform.position;

        // �]�w�H�����ۦ찾����
        phaseOffset = Random.Range(0f, Mathf.PI * 2f);
    }

    void Update()
    {
        // �ϥάۦ찾���Ȳ����H�����_�l��V
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed + phaseOffset) * floatDistance;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}
