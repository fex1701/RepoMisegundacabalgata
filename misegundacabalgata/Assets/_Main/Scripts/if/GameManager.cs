using System;
using System.Xml.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int healthPlayer = 100;
    [SerializeField] private PlayerControl player;
    [SerializeField] private UIManager Uimanager;
    [SerializeField] public Text TextScore;
    [SerializeField] public int Score;


    public void Sumarvida(int heal)
    {
        if (healthPlayer < 100)
        {
            healthPlayer += heal;
            Uimanager._lifecountercolor(Color.green);

            Uimanager.FillAmount_lifecounter(healthPlayer / 100f);
        }

        else
        {
            healthPlayer = 100;
            Debug.Log("No curo");
        }
    }
    public void RestarVida(int _Damage)

    {
        if (healthPlayer > 0)

        {


            healthPlayer -= _Damage;
            Uimanager._lifecountercolor(Color.red);
            Debug.Log(" restar " + _Damage + " puntos de vida ");
            Uimanager.FillAmount_lifecounter(healthPlayer / 100f);

        }

        if (healthPlayer <= 0)
        {
            Destroy(player.gameObject);
            Debug.Log("Se muriooo");
        }
        if (healthPlayer >= 80)
        {
            Uimanager._lifecountercolor(Color.green);
        }

        if (healthPlayer < 80)

        {
            Uimanager._lifecountercolor(Color.orange);

        }

        if (healthPlayer == 20)
        {

            Uimanager._lifecountercolor(Color.orange);
        }

        if (healthPlayer < 20)
        {
            Uimanager._lifecountercolor(Color.darkRed);
        }
    }
    public void Sumarpuntos(int _Coin)
    {
        if (Score == 0)
        {
            Score += _Coin;
            Debug.Log("+1");
        }
    }

           
        
           
     


       
    }

