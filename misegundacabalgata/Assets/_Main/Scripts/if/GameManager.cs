using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int healthPlayer = 100;
    [SerializeField] private PlayerControl player;
    [SerializeField] private UIManager Uimanager;
   public void Sumarvida(int heal)
    {
        if (healthPlayer < 100)
        {
            healthPlayer += heal;
            Uimanager._lifecountercolor(Color.green);
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

        }

        if(healthPlayer <= 0)
        {
            Destroy(player.gameObject);
            Debug.Log("Se muriooo");
        }
    }

}