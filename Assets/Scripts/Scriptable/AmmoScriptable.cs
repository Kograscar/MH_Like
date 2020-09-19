using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ammo", menuName = "Ammo")]
public class AmmoScriptable : ScriptableObject
{
    public GameObject ammo;
    public AmmoType ammoType;
    public float speed;
    public int dmgMultiplicator;
    public int koDmg;
    public int spreadPotential;
    public int piercingPotential;
}
