using UnityEngine;

public class KindTrader : Trader
{
    protected override void Trade(ITradable trader, int reputationForTrading, GameObject tradeObject)
    {
        if(trader.Reputation > 0)
            trader.Trade(tradeObject, "Я буду торговать с тобой фруктами в любом случае =)");
    }
}
