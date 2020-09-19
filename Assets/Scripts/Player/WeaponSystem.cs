using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponSystem : MonoBehaviour
{
    public WeaponsScriptable weaponScriptable;
    public List<BoxCollider> weaponColliders = new List<BoxCollider>();
    public Transform firePoint;
    public Transform weaponMesh;
    public Animator animator;
    public float damageMultiplicator = 1;
    public bool guarding;
    public ItemPouchManager pouchManager;
    public GameObject selectedAmmo;

    bool A_Input;
    bool B_Input;
    bool X_Input;
    bool Y_Input;
    bool LB_Input;
    bool RB_Input;
    bool LT_Input;
    bool RT_Input;

    #region Inputs
    public void A(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0) { A_Input = true; } else { A_Input = false; }
    }

    public void B(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0) { B_Input = true; } else { B_Input = false; }
    }

    public void X(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0) { X_Input = true; } else { X_Input = false; }
    }

    public void Y(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0) { Y_Input = true; } else { Y_Input = false; }
    }

    public void LB(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0) { LB_Input = true; } else { LB_Input = false; }
    }

    public void RB(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0) { RB_Input = true; } else { RB_Input = false; }
    }

    public void LT(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0) { LT_Input = true; } else { LT_Input = false; }
    }

    public void RT(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0) { RT_Input = true; } else { RT_Input = false; }
    }
    #endregion Inputs

    private void OnEnable()
    {
        EquipWeapon();
    }

    private void Update()
    {
        #region animator
        animator.SetBool("A", A_Input);
        animator.SetBool("B", B_Input);
        animator.SetBool("X", X_Input);
        animator.SetBool("Y", Y_Input);
        animator.SetBool("LB", LB_Input);
        animator.SetBool("RB", RB_Input);
        animator.SetBool("LT", LT_Input);
        animator.SetBool("RT", RT_Input);
        animator.SetBool("Guard", guarding);
        #endregion

        if(weaponScriptable.weaponType == WeaponType.Ranger)
        {
            selectedAmmo = pouchManager.selectedAmmo;
        }
    }

    public void EnableCollider(int numb)
    {
        weaponColliders[numb].enabled = !weaponColliders[numb];
    }

    public void EquipWeapon()
    {
        Instantiate(weaponScriptable.mesh, weaponMesh);
        weaponColliders.AddRange(weaponMesh.GetComponentsInChildren<BoxCollider>());
        animator.runtimeAnimatorController = GameManager.Instance.moveset[weaponScriptable.moveset];

    }

    public void Fire()
    {
        GameObject ammo = pouchManager.selectedAmmo;

        //animator.SetInteger("Recoil", weaponScriptable);
    }

    public void Reload()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        
    }
}
