using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "ScriptableObjects/Weapon")]
public class WeaponItem : ScriptableObject
{
    public IBulletShooter bulletType;
    public int bulletCount;
    public Sprite weaponSprite;
    public float waitTime;
}
