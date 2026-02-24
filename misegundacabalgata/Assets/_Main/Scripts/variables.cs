using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class variables : MonoBehaviour
    
{
    //Declarar variables

    public string myName = "Felipe";
    public int _edad = 18;
    public bool isBool; 

    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private TMP_Text _saludo;
    [SerializeField] private Renderer _cubo;
    [SerializeField] private BoxCollider _boxCollider;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        _cubo.material.color = Color.blue;
        _boxCollider.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
          myName = _inputField.text;
        _saludo.text = "Saludoss " + myName; 
    }
}
