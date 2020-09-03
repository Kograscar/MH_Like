using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ComboSystem : MonoBehaviour
{
    public Animator animator;

    bool aInput;
    bool bInput;
    bool yInput;
    bool rtInput;

    #region Inputs
    public void A(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0) { aInput = true; } else { aInput = false; }
    }

    public void B(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0) { bInput = true; } else{ bInput = false; }
    }

    public void Y(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0) { yInput = true; } else { yInput = false; }
    }

    public void RT(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0) { rtInput = true; } else { rtInput = false; }
    }
    #endregion Inputs

    private void Update()
    {
        animator.SetBool("A", aInput);
        animator.SetBool("B", bInput);
        animator.SetBool("Y", yInput);
        animator.SetBool("RT", rtInput);
    }
}
