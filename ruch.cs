using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruch : MonoBehaviour
{
   
   private Rigidbody2D rb;
   public float speed = 10f;
   public float szerokoscMapy = 9f;

   void Start()
   {
       rb=GetComponent<Rigidbody2D>();
   }
    
    
    void Ruch()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        Vector2 noweMiejsce = rb.position + Vector2.right * x;
        noweMiejsce.x = Mathf.Clamp(noweMiejsce.x, -szerokoscMapy, szerokoscMapy);
        rb.MovePosition(noweMiejsce);
    }

    
    void FixedUpdate()
    {
        Ruch();
    }
}
