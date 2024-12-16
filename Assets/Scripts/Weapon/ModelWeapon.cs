using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ModelWeapon: MonoBehaviour
{
    ViewWeapon _viewWeapon;
    ControllerWeapon _controllerWeapon;
    IBulletShooter _bulletShooter;

    void Start()
    {
        _controllerWeapon = GetComponent<ControllerWeapon>();
        _bulletShooter = GetComponent<IBulletShooter>();
        _viewWeapon = GetComponent<ViewWeapon>();
    }

    public void SetWeaponStats()
    {
        _controllerWeapon.bulletCount = _controllerWeapon._weaponItem.bulletCount;
        _controllerWeapon.GetComponent<SpriteRenderer>().sprite = _controllerWeapon._weaponItem.weaponSprite;
        _bulletShooter = _controllerWeapon._weaponItem.bulletType;
        _controllerWeapon.waitTime = _controllerWeapon._weaponItem.waitTime;
    }

    public void shootBullet(Transform bullet, TMPro.TextMeshProUGUI bulletCountPresenter)
    {
        _bulletShooter.ShootBullet(bullet, _controllerWeapon, bulletCountPresenter, _viewWeapon);
    }
}
