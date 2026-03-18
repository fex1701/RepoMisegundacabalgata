using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image _Lifecounter;
   
    private void Start()

    {
        _Lifecounter.color = Color.cyan;
        _Lifecounter.fillAmount = 1;
    }
    public void _lifecountercolor(Color color)
    {
        _Lifecounter.color = color;

    }

    public void FillAmount_lifecounter(float fillAmount)
    {
        _Lifecounter.fillAmount = fillAmount;
    }    
}
    