using UnityEngine;

public class Box : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    public void InteractObject() {
        Debug.Log("Box Interacted");
    }

    public bool Interact(Interactor interactor) {
        InteractObject();
        return true;
    }
}
