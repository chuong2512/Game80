using Jackal;
using UnityEngine;

[DefaultExecutionOrder(-100)]
public class GameDataManager : PersistentSingleton<GameDataManager>
{
    /*----Scriptable data-----------------------------------------------------------------------------------------------*/
    public SongSO songSo;

    /*----Data variable-------------------------------------------------------------------------------------------------*/
    [HideInInspector] public PlayerData playerData;

  

    private void OnEnable()
    {
        playerData = new GameObject(Constant.DataKey_PlayerData).AddComponent<PlayerData>();
        playerData.transform.parent = transform;
        playerData.Init();
    }
    private void Start()
    {
        Application.targetFrameRate = Mathf.Max(60, Screen.currentResolution.refreshRate);
    }
    public void ResetData()
    {
        playerData.ResetData();
    }
}