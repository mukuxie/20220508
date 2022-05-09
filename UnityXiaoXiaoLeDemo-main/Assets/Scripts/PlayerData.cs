using UnityEngine;


[CreateAssetMenu(fileName = "玩家資料", menuName = "Data/玩家資料")]
public class PlayerData : ScriptableObject
{
    // 能力值
    [Header("生命值")]
    [Range(100, 10000)]
    public int hp = 100;

    [Header("魔力值")]
    [Range(100, 10000)]
    public int mp = 100;

    [Header("攻擊力")]
    [Range(100, 10000)]
    public int atk = 10;

    [Header("防禦力")]
    [Range(100, 10000)]
    public int def = 10;






}