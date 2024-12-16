using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunBulletShooter : MonoBehaviour, IBulletShooter
{
    public float timeToWait;
    float timer;
    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShootBullet(Transform bullet, ControllerWeapon __controllerWeapon, TMPro.TextMeshProUGUI bulletPresenter, ViewWeapon __viewWeapon)
    {
        if(Time.time - timer > timeToWait && __controllerWeapon.bulletCount > 0 && Input.GetMouseButton(0))
        {
            Instantiate(bullet);
            __controllerWeapon.bulletCount--;
            string bulletString = "Bullets: " + __controllerWeapon.bulletCount;
            __viewWeapon.showBulletCount(bulletString, bulletPresenter);
            timer = Time.time;
            
        }
    }
}
