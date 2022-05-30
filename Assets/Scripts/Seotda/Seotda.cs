using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
/// <summary>
/// Ranks Of Hands
/// </summary>
[System.Serializable]
public enum RanksOfHands
{
    NineFour = -4,
    MeongteongguriNineFour = -3,
    TtaengCatcher = -2,
    Amhaengeosa = -1,
    None,
    Mangtong,
    OneKkeut,
    TwoKkeut,
    ThreeKkeut,
    FourKkeut,
    FiveKkeut,
    SixKkeut,
    SevenKkeut,
    EightKkeut,
    GaBo,
    SeRyuk,
    JangSa,
    JangPping,
    GuPping,
    Viper,
    Alli,
    PpingTtaeng,
    TwoTtaeng,
    ThreeTtaeng,
    FourTtaeng,
    FiveTtaeng,
    SixTtaeng,
    SevenTtaeng,
    EightTtaeng,
    NineTtaeng,
    JangTtaeng,
    OneThreeGwangTtaeng,
    OneEgihtGwangTtaeng,
    ThreeEightGwangTtaeng

}
/// <summary>
/// Card Property
/// </summary>
[System.Serializable]
public enum YinAndYang
{
    None,
    Yin,
    Yang
}
/// <summary>
/// Card Element
/// </summary>
public enum FiveElements
{
    None,
    Wood,
    Fire,
    Earth,
    Metal,
    Water
}
/// <summary>
/// Property of Hwatoo
/// </summary>
[System.Serializable]
public class Hwatoo
{
    [SerializeField] private int number;
    [SerializeField] bool isGwang = false;
    [SerializeField] YinAndYang yinAndYang = YinAndYang.None;
    [SerializeField] FiveElements fiveElements = FiveElements.None;

    public Hwatoo(int _number, bool _isGwang, YinAndYang _yinAndYang, FiveElements _fiveElements)
    {
        number = _number;
        isGwang = _isGwang;
        yinAndYang = _yinAndYang;
        fiveElements = _fiveElements;
    }
}
public class Seotda : MonoBehaviour
{
    public List<Hwatoo> hwatooDeck;
    public List<int> usedNums;
    public Hwatoo[] selectedHwatoos = new Hwatoo[2];
    private void Awake()
    {
        InitHwatooDeck();
    }
    /// <summary>
    /// Init Deck
    /// </summary>
    [Button]
    public void InitHwatooDeck()
    {
        hwatooDeck.Clear();
        for (int i = 0; i < 10; i++)
        {
            hwatooDeck.Add(new Hwatoo(i + 1, false, YinAndYang.Yin, FiveElements.Wood));
        }
        for (int i = 0; i < 10; i++)
        {
            hwatooDeck.Add(new Hwatoo(i + 1, false, YinAndYang.Yin, FiveElements.Fire));
        }
        for (int i = 0; i < 10; i++)
        {
            hwatooDeck.Add(new Hwatoo(i + 1, false, YinAndYang.Yin, FiveElements.Earth));
        }
        for (int i = 0; i < 10; i++)
        {
            hwatooDeck.Add(new Hwatoo(i + 1, false, YinAndYang.Yin, FiveElements.Metal));
        }
        for (int i = 0; i < 10; i++)
        {
            hwatooDeck.Add(new Hwatoo(i + 1, false, YinAndYang.Yin, FiveElements.Water));
        }
        hwatooDeck.Add(new Hwatoo(1, true, YinAndYang.Yin, FiveElements.Wood));
        hwatooDeck.Add(new Hwatoo(3, true, YinAndYang.Yin, FiveElements.Wood));
        hwatooDeck.Add(new Hwatoo(8, true, YinAndYang.Yin, FiveElements.Wood));
        hwatooDeck.Add(new Hwatoo(1, true, YinAndYang.Yin, FiveElements.Fire));
        hwatooDeck.Add(new Hwatoo(3, true, YinAndYang.Yin, FiveElements.Fire));
        hwatooDeck.Add(new Hwatoo(8, true, YinAndYang.Yin, FiveElements.Fire));
        hwatooDeck.Add(new Hwatoo(1, true, YinAndYang.Yin, FiveElements.Earth));
        hwatooDeck.Add(new Hwatoo(3, true, YinAndYang.Yin, FiveElements.Earth));
        hwatooDeck.Add(new Hwatoo(8, true, YinAndYang.Yin, FiveElements.Earth));
        hwatooDeck.Add(new Hwatoo(1, true, YinAndYang.Yin, FiveElements.Metal));
        hwatooDeck.Add(new Hwatoo(3, true, YinAndYang.Yin, FiveElements.Metal));
        hwatooDeck.Add(new Hwatoo(8, true, YinAndYang.Yin, FiveElements.Metal));
        hwatooDeck.Add(new Hwatoo(1, true, YinAndYang.Yin, FiveElements.Water));
        hwatooDeck.Add(new Hwatoo(3, true, YinAndYang.Yin, FiveElements.Water));
        hwatooDeck.Add(new Hwatoo(8, true, YinAndYang.Yin, FiveElements.Water));
        for (int i = 0; i < 10; i++)
        {
            hwatooDeck.Add(new Hwatoo(i + 1, false, YinAndYang.Yang, FiveElements.Wood));
        }
        for (int i = 0; i < 10; i++)
        {
            hwatooDeck.Add(new Hwatoo(i + 1, false, YinAndYang.Yang, FiveElements.Fire));
        }
        for (int i = 0; i < 10; i++)
        {
            hwatooDeck.Add(new Hwatoo(i + 1, false, YinAndYang.Yang, FiveElements.Earth));
        }
        for (int i = 0; i < 10; i++)
        {
            hwatooDeck.Add(new Hwatoo(i + 1, false, YinAndYang.Yang, FiveElements.Metal));
        }
        for (int i = 0; i < 10; i++)
        {
            hwatooDeck.Add(new Hwatoo(i + 1, false, YinAndYang.Yang, FiveElements.Water));
        }
        hwatooDeck.Add(new Hwatoo(1, true, YinAndYang.Yang, FiveElements.Wood));
        hwatooDeck.Add(new Hwatoo(3, true, YinAndYang.Yang, FiveElements.Wood));
        hwatooDeck.Add(new Hwatoo(8, true, YinAndYang.Yang, FiveElements.Wood));
        hwatooDeck.Add(new Hwatoo(1, true, YinAndYang.Yang, FiveElements.Fire));
        hwatooDeck.Add(new Hwatoo(3, true, YinAndYang.Yang, FiveElements.Fire));
        hwatooDeck.Add(new Hwatoo(8, true, YinAndYang.Yang, FiveElements.Fire));
        hwatooDeck.Add(new Hwatoo(1, true, YinAndYang.Yang, FiveElements.Earth));
        hwatooDeck.Add(new Hwatoo(3, true, YinAndYang.Yang, FiveElements.Earth));
        hwatooDeck.Add(new Hwatoo(8, true, YinAndYang.Yang, FiveElements.Earth));
        hwatooDeck.Add(new Hwatoo(1, true, YinAndYang.Yang, FiveElements.Metal));
        hwatooDeck.Add(new Hwatoo(3, true, YinAndYang.Yang, FiveElements.Metal));
        hwatooDeck.Add(new Hwatoo(8, true, YinAndYang.Yang, FiveElements.Metal));
        hwatooDeck.Add(new Hwatoo(1, true, YinAndYang.Yang, FiveElements.Water));
        hwatooDeck.Add(new Hwatoo(3, true, YinAndYang.Yang, FiveElements.Water));
        hwatooDeck.Add(new Hwatoo(8, true, YinAndYang.Yang, FiveElements.Water));
    }
    /// <summary>
    /// Select Hwatoos(First)
    /// </summary>
    [Button]
    public void SelectHwatoosFirst()
    {
        usedNums.Clear();
        selectedHwatoos[0] = hwatooDeck[SelectNum()];
        selectedHwatoos[1] = hwatooDeck[SelectNum()];
    }
    /// <summary>
    /// Change selected Hwatoo
    /// </summary>
    /// <param name="num">Num which has to be changed</param>
    [Button]
    public void ResetHwatoo(int num)
    {
        selectedHwatoos[num] = hwatooDeck[SelectNum()];
    }
    /// <summary>
    /// Select number which is not included in usedNums.
    /// </summary>
    /// <returns>Random Number</returns>
    public int SelectNum()
    {
        int result;
        Random.InitState((int)System.DateTime.Now.Ticks);
        result = Random.Range(0, hwatooDeck.Count);
        while (usedNums.Contains(result))
        {
            result = Random.Range(0, hwatooDeck.Count);
        }
        usedNums.Add(result);
        return result;
    }
}
