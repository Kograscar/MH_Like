using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsScriptable : ScriptableObject
{
    public GameObject mesh;
    public WeaponType weaponType;
    public float damage;
    public WeaponTree weapon;
    public int moveset;
    public int guardPower = 50;
}
