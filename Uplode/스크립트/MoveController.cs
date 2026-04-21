using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public int moveInt_x = 1; 
    // 데이터형이 정수(int)인 변수 moveInt_x
    public float move_X = 5.0f;
    // 데이터형이 실수(float)인 변수 move_X 
 
    
    void Update()
        //Update() 매 프레임마다 실행
    {
        /*if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            //정수값
            transform.Translate(Vector3.right * move_X);
            //실수값
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * move_X);

          
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * move_X);
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * move_X);
        }*/

        /*
            float h = Input.GetAxis("Horizontal"); 
            float v = Input.GetAxis("Vertical");  

            if (h != 0)
            {
                transform.Translate(Vector3.right * h * move_X);
            }

            if (v != 0)
            {
                transform.Translate(Vector3.up * v * move_X);
            }
        */
       
        
            float delta = move_X * Time.deltaTime;

            float moveX = 0f;
            float moveY = 0f;

            if (Input.GetKey(KeyCode.RightArrow)) moveX = delta;
            if (Input.GetKey(KeyCode.LeftArrow)) moveX = -delta;

            if (Input.GetKey(KeyCode.UpArrow)) moveY = delta;
            if (Input.GetKey(KeyCode.DownArrow)) moveY = -delta;

            transform.Translate(new Vector3(moveX, moveY, 0));
        
    }
}
