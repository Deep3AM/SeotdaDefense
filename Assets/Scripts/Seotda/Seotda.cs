using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using System;
using Random = UnityEngine.Random;


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
        selectedHwatoos = new Hwatoo[2];
        usedNums.Clear();
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
        Array.Sort(selectedHwatoos, (a, b) => (a.Number < b.Number) ? -1 : 1);
        for (int i = 0; i < 2; i++)
        {
            Debug.Log(selectedHwatoos[i].Number);
        }
    }
    /// <summary>
    /// Change selected Hwatoo
    /// </summary>
    /// <param name="num">Num which has to be changed</param>
    [Button]
    public void ResetHwatoo(int num)
    {
        selectedHwatoos[num] = hwatooDeck[SelectNum()];
        Array.Sort(selectedHwatoos, (a, b) => (a.Number < b.Number) ? -1 : 1);
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
    /// <summary>
    /// Assess Cards...
    /// </summary>
    [Button]
    public void Assessment()
    {
        if (selectedHwatoos[0].Number == 3 && selectedHwatoos[0].IsGwang && selectedHwatoos[1].Number == 8 && selectedHwatoos[1].IsGwang)
        {
            Debug.Log("ThreeEightGwangTtaeng");
        }
        else if (selectedHwatoos[0].Number == 1 && selectedHwatoos[0].IsGwang && selectedHwatoos[1].Number == 8 && selectedHwatoos[1].IsGwang)
        {
            Debug.Log("OneEightGwangTtaeng");
        }
        else if (selectedHwatoos[0].Number == 1 && selectedHwatoos[0].IsGwang && selectedHwatoos[1].Number == 3 && selectedHwatoos[1].IsGwang)
        {
            Debug.Log("OneThreeGwangTtaeng");
        }
        else if (selectedHwatoos[0].Number == selectedHwatoos[1].Number)
        {
            int ttaeng = selectedHwatoos[0].Number;
            if (ttaeng == 10)
            {
                Debug.Log("JangTtaeng");
            }
            else if (ttaeng == 9)
            {
                Debug.Log("NineTtaeng");
            }
            else if (ttaeng == 8)
            {
                Debug.Log("EightTtaeng");
            }
            else if (ttaeng == 7)
            {
                Debug.Log("SevenTtaeng");
            }
            else if (ttaeng == 6)
            {
                Debug.Log("SixTtaeng");
            }
            else if (ttaeng == 5)
            {
                Debug.Log("FiveTtaeng");
            }
            else if (ttaeng == 4)
            {
                Debug.Log("FourTtaeng");
            }
            else if (ttaeng == 3)
            {
                Debug.Log("ThreeTtaeng");
            }
            else if (ttaeng == 2)
            {
                Debug.Log("TwoTtaeng");
            }
            else if (ttaeng == 1)
            {
                Debug.Log("OneTtaeng");
            }
        }
        else if (selectedHwatoos[0].Number == 1 && selectedHwatoos[1].Number == 2)
        {
            Debug.Log("Alli");
        }
        else if (selectedHwatoos[0].Number == 1 && selectedHwatoos[1].Number == 4)
        {
            Debug.Log("Viper");
        }
        else if (selectedHwatoos[0].Number == 1 && selectedHwatoos[1].Number == 9)
        {
            Debug.Log("GuPping");
        }
        else if (selectedHwatoos[0].Number == 1 && selectedHwatoos[1].Number == 10)
        {
            Debug.Log("JangPping");
        }
        else if (selectedHwatoos[0].Number == 4 && selectedHwatoos[1].Number == 6)
        {
            Debug.Log("SeRyuk");
        }
        else
        {
            int kkeut = (selectedHwatoos[0].Number + selectedHwatoos[1].Number) % 10;
            if (kkeut == 9)
            {
                Debug.Log("Gabo");
            }
            else if (kkeut == 8)
            {
                Debug.Log("EightKkeut");
            }
            else if (kkeut == 7)
            {
                Debug.Log("SevenKkeut");
            }
            else if (kkeut == 6)
            {
                Debug.Log("SixKkeut");
            }
            else if (kkeut == 5)
            {
                Debug.Log("FiveKkeut");
            }
            else if (kkeut == 4)
            {
                Debug.Log("FourKkeut");
            }
            else if (kkeut == 3)
            {
                Debug.Log("ThreeKkeut");
            }
            else if (kkeut == 2)
            {
                Debug.Log("TwoKkeut");
            }
            else if (kkeut == 1)
            {
                Debug.Log("OneKkeut");
            }
            else if (kkeut == 0)
            {
                Debug.Log("MangTong");
            }
        }
    }
}
