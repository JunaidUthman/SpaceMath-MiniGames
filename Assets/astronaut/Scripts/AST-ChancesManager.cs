using UnityEngine;
using UnityEngine.UI;

public class ChancesManager : MonoBehaviour
{
    public int life = 5;
    public Image[] hearts;

    public void LoseLife()
    {
        if (life > 0)
        {
            life--;

            // D�sactiver le dernier c�ur actif
            if (life < hearts.Length)
            {
                hearts[life].enabled = false;
            }
        }
    }
}
