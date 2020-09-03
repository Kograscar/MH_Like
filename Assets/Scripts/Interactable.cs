using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public MeshRenderer meshRenderer;

    private void OnEnable()
    {
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
    }

    public void Interact()
    {
        Debug.Log("Interact");
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        meshRenderer.material.color = Color.red;
        yield return new WaitForSeconds(1);
        meshRenderer.material.color = Color.red;
    }
}
