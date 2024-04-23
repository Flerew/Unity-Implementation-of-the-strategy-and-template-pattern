using UnityEngine;

public class EvilTrader : Trader
{
    protected override void Trade(ITradable trader, int reputationForTrading, GameObject tradeObject)
    {
        Debug.Log("Иди своей дорогой Сталкер");
    }
}
