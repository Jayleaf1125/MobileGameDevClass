using UnityEngine;
using System.Collections;
using AYellowpaper.SerializedCollections;

public enum BuffTypes
{
    IncreaseHealth,
    DecreasHealth,
    IncreaseDamage, 
    DecreasDamage
}

[CreateAssetMenu(fileName = "New Buff Card", menuName = "Misc/Buff Card")]
public class BuffCardSO : ScriptableObject
{
    [SerializedDictionary("BuffTypes", "Value")]
    public SerializedDictionary<BuffTypes, int> BuffDict = new SerializedDictionary<BuffTypes, int>();
}
