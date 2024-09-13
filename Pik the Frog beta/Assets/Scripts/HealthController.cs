using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    private int frogHearts = 3;

    public int FrogHearts
    {
        get { return frogHearts; }
        set { frogHearts = value; }
    }

    public void DecreaseInHealth()
    {
        frogHearts--;
    }
}
