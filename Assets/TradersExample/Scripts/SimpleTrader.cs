using UnityEngine;

public class SimpleTrader : Trader
{
    protected override void Trade(ITradable trader, int reputationForTrading, GameObject tradeObject)
    {
        if (trader.Reputation >= reputationForTrading)
            trader.Trade(tradeObject, $"����� ��������� {trader.Reputation} ���������� ��� ������� �����.");
        else
            Debug.Log($"��������� ��� �������� �� ���� ������ ���� {reputationForTrading}. � � ���� {trader.Reputation}");
    }
}
