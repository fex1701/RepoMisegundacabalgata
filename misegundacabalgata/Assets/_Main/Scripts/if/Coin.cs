using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private int _Coin;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.Sumarpuntos(_Coin);
            Destroy(this.gameObject);
        }
    }
}