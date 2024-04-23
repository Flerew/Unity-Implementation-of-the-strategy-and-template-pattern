using UnityEngine;

public class SimpleTrader : Trader
{
    protected override void Trade(ITradable trader, int reputationForTrading, GameObject tradeObject)
    {
        if (trader.Reputation >= reputationForTrading)
            trader.Trade(tradeObject, $"Твоей репутации {trader.Reputation} достаточно для покупки брони.");
        else
            Debug.Log($"Репутация для торговли со мной должна быть {reputationForTrading}. А у тебя {trader.Reputation}");
    }
}
