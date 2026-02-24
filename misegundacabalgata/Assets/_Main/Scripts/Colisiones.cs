using UnityEngine;

public class Colisiones : MonoBehaviour
   
{
     void OnCollisionEnter2D (Collision2D collision)
    {
        Debug.Log("OnCollisionEnter");
    }

     void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("OnCollisionExit");
    }
     void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("OnCollisionStay");

    }
}
