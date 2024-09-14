using System;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public Action OnHealthController;

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

        OnHealthController?.Invoke();
    }
}
