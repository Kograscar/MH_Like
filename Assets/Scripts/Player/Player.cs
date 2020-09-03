using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Player : MonoBehaviour
{
    public WeaponSystem weaponSystem;
    public float baseSpeed = 1;
    public TMP_Text text;
    public List<Interactable> interactables;

    [SerializeField] Transform character;
    
    Vector2 movementInput;
    Vector2 lookInput;


    private void OnEnable()
    {
        weaponSystem = FindObjectOfType<WeaponSystem>();
    }

    public void Update()
    {
        Movement();
    }

    #region Inputs
    public void MovementInput(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    public void LookInput(InputAction.CallbackContext context)
    {
        lookInput = context.ReadValue<Vector2>();
    }
    #endregion

    void Movement()
    {
        Vector3 position = character.position;
        position.x += movementInput.x * Time.deltaTime * baseSpeed;
        position.z += movementInput.y * Time.deltaTime * baseSpeed;
        character.position = position;
    }
    
    public void GetHit(float damage)
    {
        float finalDamage = new float();

        if (!weaponSystem.guarding)
        {

        }
        else
        {
            finalDamage = damage * (100 - weaponSystem.weaponScriptable.guardPower);
        }

        weaponSystem.animator.SetTrigger("Hit");
    }

    public void GetHit()
    {
        weaponSystem.animator.SetTrigger("Hit");
    }

    public void OnTriggerEnter(Collider other)
    {
        var interact = other.GetComponent<Interactable>();
        if (interact != null)
        {
            interactables.Add(interact);
            UpdateText();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        interactables.Remove(other.GetComponent<Interactable>());
        UpdateText();
    }

    public void UpdateText()
    {
        text.text = "";
        if (interactables.Count != 0)
        {
            for (int i = 0; i < interactables.Count; i++)
            {
                text.text += i + " : " + interactables[i].name + "\n";
            }
        }
        else
        {
            text.text = "No Interactables";
        }
    }
}
