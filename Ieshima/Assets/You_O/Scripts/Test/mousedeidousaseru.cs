using UnityEngine;
using System.Collections;

public class mousedeidousaseru : MonoBehaviour
{
    public Camera MainCamera;
    public Transform target;
    public Transform center;
    bool flag;

    // Use this for initialization
    void Start()
    {
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 hitPoint;
        //マウスカーソルからRay放射
        // maincameraにtagを設定する
        // boxcolliderをつける
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // 仮想的な線を利用した衝突検出する
        // カメラから、マウス入力のあった位置までの間にある、オブジェクトを格納する
        // 任意の位置から任意の方向に向けて架空の線を出し、その線分上にあるオブジェクトを取得する

        // RaycastHit型の変数
        RaycastHit hit;

        // if(Physics.Raycast( transform.position,Vector3.right,out hit, 10 ))
        // positionから右方向に10進んだ先までにオブジェクトがあればtrueが返される
        // 第三引数にoutで指定すると衝突したオブジェクトの情報が入る

        // 第一引数にはRaycastの原点の位置、第二引数は方向、
        // 第三引数には衝突情報、第四引数には検知を行う距離、第五引数にはレイヤーマスクをとります
        // ※第三引数まで必須

        // Rayが飛ばされたところから、200の間にオブジェクトがあればtrueを返し、hitにそれを格納する
        if (Physics.Raycast(ray, out hit, 200))
        {
            if (hit.collider.gameObject == null)
            {
                return;
            }
            // hitした位置を格納する
            hitPoint = hit.point;
        }
        else
        {
            return;
        }

        target.transform.position = hitPoint;
    }
}
