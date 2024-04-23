using UnityEngine;

public interface ITradable
{
    int Reputation { get; }
    
    void Trade(GameObject tradeObject, string tradeMessage);
}
