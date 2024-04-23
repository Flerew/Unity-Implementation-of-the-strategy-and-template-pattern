using UnityEngine;

public abstract class Trader : MonoBehaviour
{
    private GameObject _tradeObject;
    private int _reputationForTrading;

    public void Initialize(GameObject tradeObject, int reputationForTrading)
    {
        _tradeObject = tradeObject;
        _reputationForTrading = reputationForTrading;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out ITradable tradable))
        {
            Trade(tradable, _reputationForTrading, _tradeObject);
        }
    }

    protected abstract void Trade(ITradable trader, int reputationForTrading, GameObject tradeObject);
}
