using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControllerWeapon : MonoBehaviour
{
    public bool bulletShot = false;
    public int bulletCount;
    public TextMeshProUGUI bulletCountPresenter;
    [SerializeField] Transform bullet;
    public ModelWeapon _modelWeapon;
    public ViewWeapon _viewWeapon;
    public WeaponItem _weaponItem;
    public float waitTime;
    void Start()
    {
        string bulletString = "Bullets: " + bulletCount;
        _viewWeapon.showBulletCount(bulletString, bulletCountPresenter);
    }

    void Update()
    {
        _modelWeapon.shootBullet(bullet, bulletCountPresenter);
    }
}
