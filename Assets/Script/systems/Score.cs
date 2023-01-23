using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour, IDataPersistence
{
    private int Point = 0;

    private TextMeshProUGUI Pointtext;

    private void Awake()
    {
        Pointtext = this.GetComponent<TextMeshProUGUI>();
    }

    public void LoadData(GameData data)
    {
        this.Point = data.Point;
    }

    public void SaveData(ref GameData data)
    {
        data.Point = this.Point;
    }

    private void Start()
    {
        GameEventsManager.instance.OnEnemyKilled += OnEnemyKilled;
    }

    private void OnEnemyKilled()
    {
        Point++;
    }

    private void Update()
    {
        Pointtext.text = "x" + Point;
    }


}
