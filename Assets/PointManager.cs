using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class PointsManager : MonoBehaviour
{
    public TMP_Text pointsText;
    public TMP_Text upgradeCostText;
    public TMP_Text upgradePPSCostText;
    public TMP_Text PPSText;
    public int points = 0;
    private int pointsPerClick = 1;
    private int upgradeCost = 1;
    public float pointsAddInterval = 1;
    private float timer;
    public int pointsPerSecond;
    public int upgradePointPerSecondCost = 500;
    public float TimerZipZap;
    public int truefalse;
    public Image[] zipzab;
    public Image[] aLotOfZipzabs;
    public AudioSource[] aLotOfRaysClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        upgradeCostText.text = upgradeCost.ToString();
        pointsText.text = points.ToString();
        upgradePPSCostText.text = upgradePointPerSecondCost.ToString();
        PPSText.text = pointsPerSecond.ToString();
        truefalse = 0;
        TimerZipZap = 0;
        zipzab[0].enabled = false;
        aLotOfZipzabs[0].enabled = false;
        aLotOfRaysClip[0].mute = true;
    }

    // Update is called once per frame
    private void Update()
    {


        timer += Time.deltaTime;
        if (timer > pointsAddInterval)
        {
            GeneratePoints(pointsPerSecond);
            timer = 0;

        }
        if (truefalse >= 1)
        { 
            TimerZipZap += Time.deltaTime * 100;
            if (truefalse >= 1)
            {
                zipzab[0].enabled = true;
            }
            if (TimerZipZap <= 0)
            {
                zipzab[0].enabled = false;
            }
            if (TimerZipZap >= 120)
            {
                zipzab[0].enabled = false;
                truefalse = 0;
                TimerZipZap = 0;
            }
        }
        if (pointsPerSecond >= 1)
        {
            aLotOfZipzabs[0].enabled = true;
            aLotOfRaysClip[0].mute = false;
        }
    }

    public void GeneratePoints(int addedPoints)
    {
        points += addedPoints;
        pointsText.text = points.ToString();
        print(points);
    }

    public void AddPointsPerClick()
    {
        GeneratePoints(pointsPerClick);
    }
    public void Upgrade()
    {
        if (points >= upgradeCost)
        {

            points -= upgradeCost;
            pointsText.text = points.ToString();
            upgradeCost++;
            upgradeCostText.text = upgradeCost.ToString();
            pointsPerClick += 1;
            Debug.Log("Upgraded successfully");
        }
        else
        {
            Debug.LogError("Not enough points");
        }
    }
    public void UpdatePointsPerSecond()
    {
        if (points >= upgradePointPerSecondCost)
        {
            points -= upgradePointPerSecondCost;
            pointsText.text = points.ToString();
            pointsPerSecond += 1;
            PPSText.text = pointsPerSecond.ToString();

            upgradePointPerSecondCost += 2;
            upgradePPSCostText.text = upgradePointPerSecondCost.ToString();
        }
    }

    private bool TrySpendPoints(int amount)
    {
        if (points >= amount)
        {
            points -= amount;
            pointsText.text = points.ToString();
            return true;

        }
        return false;
    }

    public void ShowZipZap()
    {
        truefalse = 1;

    }

}