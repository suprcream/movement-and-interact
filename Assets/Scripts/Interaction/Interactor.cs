using UnityEngine;

public class Interactor : MonoBehaviour
{
    private Transform interactorSource;
    public float interactRange;

    private void Start() {
        interactorSource = GetComponent<Transform>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            Ray ray = new Ray(interactorSource.position, interactorSource.forward);
            if (Physics.Raycast(ray, out RaycastHit hitInfo, interactRange)) {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObject)) {
                    interactObject.Interact(this);
                }
            }
        }
    }
}
