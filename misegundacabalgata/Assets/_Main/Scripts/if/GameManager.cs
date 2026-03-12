using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int healthPlayer = 100;
    public void Sumarvida(int heal)
    {
        if (healthPlayer < 100)
        {
            healthPlayer += heal;
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
            Debug.Log("restar" + _Damage + "puntos de vida");

        }

    }
}