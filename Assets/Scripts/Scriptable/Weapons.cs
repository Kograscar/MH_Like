using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapons")]
public class Weapons : ScriptableObject
{
    public GameObject mesh;
    public float damage;
    public enum WeaponType { GS, HBG};
    public WeaponType weaponType;
    public int moveset;
    public int guardPower = 50;
}
