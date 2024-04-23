using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class Market : MonoBehaviour
{
    [SerializeField] private EvilTrader _evilTrader;
    [SerializeField] private KindTrader _kindTrader;
    [SerializeField] private SimpleTrader _simpleTrader;
    [SerializeField] private int _simpleTradeReputation;

    private void Awake()
    {
        _evilTrader.Initialize(null, int.MaxValue);
        _kindTrader.Initialize(null, int.MinValue);
        _simpleTrader.Initialize(null, _simpleTradeReputation);
    }
}
