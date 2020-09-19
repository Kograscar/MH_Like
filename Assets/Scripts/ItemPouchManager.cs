using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ItemPouchManager : MonoBehaviour
{
    public GameObject selectedItem;
    public GameObject selectedAmmo;
    public List<GameObject> ammos;
    [SerializeField] int activeAmmo;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ChangeAmmo(InputAction.CallbackContext context)
    {
        float value = context.ReadValue<float>();

        if(value > 0)
        {
            if(activeAmmo < ammos.Count - 1)
            {
                activeAmmo++;
            }
            else
            {
                activeAmmo = 0;
            }
        }
        else
        {
            if(activeAmmo > 0)
            {
                activeAmmo--;
            }
            else
            {
                activeAmmo = ammos.Count - 1;
            }
        }

        selectedAmmo = ammos[activeAmmo];
    }

}
