using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapons/CQC Weapon")]
public class CQCWeaponsScriptable : WeaponsScriptable
{
    public new WeaponType weaponType = WeaponType.BladeMaster;
}
