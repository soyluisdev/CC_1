using UnityEngine;

public class InfoOnApproach : MonoBehaviour
{
    public Transform player;         // A qué objeto detectar (puede ser la cámara o el jugador)
    public GameObject infoPanel;     // El panel de información
    public float triggerDistance = 5f;  // Distancia para mostrar la info

    void Update()
    {
        if (player == null || infoPanel == null)
            return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < triggerDistance)
        {
            infoPanel.SetActive(true);
        }
        else
        {
            infoPanel.SetActive(false);
        }
    }
}

