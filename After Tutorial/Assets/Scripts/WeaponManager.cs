using Invector.vCharacterController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public GameObject weapon;
    public vThirdPersonController tpc;

    public void EnableWeaponCollider(int isEnable)
    {
        //Check if the character is holding a weapon
        if(weapon != null)
        {
            var col = weapon.GetComponent<Collider>();

            //Check if the weapon has a collider
            if(col != null)
            {
                if(isEnable == 1)
                {
                    col.enabled = true;
                }
                else
                {
                    col.enabled = false;
                }
            }
        }
    }

    public void EnableMovement(bool enable)
    {
        if(enable == false)
        {
            tpc.lockMovement = true;
            tpc.lockRotation = true;
        }
        else
        {
            tpc.lockMovement = false;
            tpc.lockRotation = false;
        }
    }
}
