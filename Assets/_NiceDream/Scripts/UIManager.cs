using System.Collections;
using System.Collections.Generic;
using Jackal;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    public GameObject panelStart, panelSetting, panelApp;

    public void BuyPack()
    {
        IAPManager.OnPurchaseSuccess =
            () =>
            {
                GameDataManager.Instance.playerData.UnlockPack();
                ShowApp();
            };
    }

    void Start()
    {
        ShowApp();
    }


    public void ShowApp()
    {
        panelStart.SetActive(false);
        panelApp.SetActive(true);
    }
}