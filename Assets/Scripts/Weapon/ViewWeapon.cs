using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewWeapon : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showBulletCount(string presentedText, TMPro.TextMeshProUGUI bulletCountPresenter)
    {
        bulletCountPresenter.text = presentedText;
    }
}
