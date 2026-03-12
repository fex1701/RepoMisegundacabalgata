using Unity.VisualScripting;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private int heal;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.Sumarvida(heal);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

    }



}
