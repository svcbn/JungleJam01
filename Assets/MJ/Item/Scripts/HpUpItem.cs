using UnityEngine;

/// <summary>
/// [MJ] 플레이어의 체력을 증가 시키는 아이템에 적용될 스크립트
/// </summary>
public class HpUpItem : PlayerItem
{
    [Tooltip("증가시킬 체력을 입력")]
    public int value;

    public HpUpItem()
    {
        Type = ItemType.PlayerHpUp;
    }
    public override void Execute()
    {
        Target.HP += value;
    }
}