using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public abstract class Interactable : MonoBehaviour {
    
    public float radius;
    public LayerMask layerMask;
    public KeyCode key;
    public Text interactUI;
    public string UIText = "Press F To Open The Item";
    
    private void Start() {
        interactUI.text = UIText;
    }

    private void Update() {
        if(Physics.CheckSphere(transform.position, radius, layerMask)) {
            OnRange();
        } else {
            NotInRange();
        }
    }

    protected virtual void OnRange() {
        // Display the UI
        if(interactUI.enabled != true)
            interactUI.enabled = true;
        // if Player press KeyCode then Do Something
        if(Input.GetKeyDown(key)) {
            OnInteract();
        }
    }

    protected virtual void NotInRange() {
        // Remove the interactUI
        if(interactUI.enabled != false)
            interactUI.enabled = false;
    }

    protected abstract void OnInteract();

    private void OnDrawGizmos() {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

}