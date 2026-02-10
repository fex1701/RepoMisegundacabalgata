using UnityEngine;

public class variables : MonoBehaviour
    
{
    //Declarar variables

    string myName = "Felipe";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      Debug.Log("Hola" + myName);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola" + myName);
    }
}
