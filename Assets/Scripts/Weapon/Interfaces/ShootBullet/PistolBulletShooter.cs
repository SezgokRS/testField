using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBulletShooter : MonoBehaviour, IBulletShooter
{
    void Start()
    {
        
    }

    void Update()
    {

    }
    public void ShootBullet(Transform bullet, ControllerWeapon __controllerWeapon, TMPro.TextMeshProUGUI bulletPresenter, ViewWeapon __viewWeapon)
    {

        if (__controllerWeapon.bulletCount > 0 && Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet);
            __controllerWeapon.bulletCount--;
            string bulletString = "Bullets: " + __controllerWeapon.bulletCount;
            __viewWeapon.showBulletCount(bulletString, bulletPresenter);
        }
    }

}
