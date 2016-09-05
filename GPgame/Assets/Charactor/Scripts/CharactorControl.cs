using UnityEngine;
using System.Collections;

public class CharactorControl : MonoBehaviour {

    private Vector2 move = Vector2.zero;

    public float Speed;                         // キャラクター移動速度
    public float JumpSpeed;                     // ジャンプ距離
    
    private const float GRAVITY = 9.8f;			// 重力
    private bool isGrounded;                    // 地面衝突判定
   
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
        Move();

	}


    void Move()
    {
        float y = move.y;
        move = new Vector2(Input.GetAxis("Horizontal"), 0.0f);
        move *= Speed;
        move.y += y;

        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                move.y = JumpSpeed;
            }
        }
        else
        {
            move.y -= GRAVITY * Time.deltaTime;
        }

        //Move(move * Speed * Time.deltaTime);

        transform.Translate(move * Time.deltaTime * Speed);
        
    }

    void OnCollisionStay(Collision Ground)
    {
        if (Ground.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit(Collision Ground)
    {
        if (Ground.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
