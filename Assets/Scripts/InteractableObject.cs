using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{

    public Text ObjectText;
    public UnityEvent clicked;

    private void OnMouseDown()
    {
        ObjectText.text = this.gameObject.name;
        this.gameObject.SetActive(false);

        clicked.Invoke();
    }


}

