using UnityEngine;

public class Player : MonoBehaviour, ITradable
{
    [SerializeField] private int _reputation;

    public int Reputation => _reputation;

    public void Trade(GameObject tradeObject, string tradeMessage)
    {
        Debug.Log(tradeMessage);
    }
}
