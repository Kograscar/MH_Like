using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapons/Ranged Weapon")]
public class RangedWeaponsScriptable : WeaponsScriptable
{
    public new WeaponType weaponType = WeaponType.Ranger;
    public List<AmmoInfo> ammoInfos;
}

[System.Serializable]
public class AmmoInfo
{
    public AmmoType ammoType;
    public int recoil;
    public int reloadSpeed;
    public int MagazineCapacity;
}
