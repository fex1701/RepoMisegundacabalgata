using UnityEngine;
using TMPro;

public class variables : MonoBehaviour
    
{
    //Declarar variables

    public string myName = "Felipe";
    public int _edad = 18;

    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private TMP_Text _saludo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
          myName = _inputField.text;
        _saludo.text = "Saludoss " + myName; 
    }
}
