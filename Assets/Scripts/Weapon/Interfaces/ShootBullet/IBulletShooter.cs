using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBulletShooter
{    
    public void ShootBullet(Transform bullet, ControllerWeapon __controllerWeapon, TMPro.TextMeshProUGUI bulletPresenter, ViewWeapon __viewWeapon);
}
