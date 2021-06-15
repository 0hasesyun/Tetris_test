using System.Collections.Generic;
using UnityEngine;

public class Mino : MonoBehaviour
{
    // 
    public float previousTime;
    // mino��������^�C��
    public float fallTime = 1f;

    // mino�֐�
    public Vector3 rotationPoint;

    void Update()
    {
        MinoMovememt();
    }

    private void MinoMovememt()
    {
        // �����L�[�ō��ɓ���
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        // �E���L�[�ŉE�ɓ���
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        // �����ŉ��Ɉړ������A�����L�[�ł��ړ�����
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Time.time - previousTime >= fallTime)
        {
            transform.position += new Vector3(0, -1, 0);
            previousTime = Time.time;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // mino������L�[�������ĉ�]������
            transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0, 0, 1), 90);
        }
    }
}