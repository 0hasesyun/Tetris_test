using System.Collections.Generic;
using UnityEngine;

public class Mino : MonoBehaviour
{
    // 
    public float previousTime;
    // minoが落ちるタイム
    public float fallTime = 1f;

    // mino関数
    public Vector3 rotationPoint;

    void Update()
    {
        MinoMovememt();
    }

    private void MinoMovememt()
    {
        // 左矢印キーで左に動く
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        // 右矢印キーで右に動く
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        // 自動で下に移動させつつ、下矢印キーでも移動する
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Time.time - previousTime >= fallTime)
        {
            transform.position += new Vector3(0, -1, 0);
            previousTime = Time.time;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // minoを上矢印キーを押して回転させる
            transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0, 0, 1), 90);
        }
    }
}