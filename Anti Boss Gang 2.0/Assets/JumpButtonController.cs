using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpButtonController : MonoBehaviour
{
    public Move jumpController;

    public Button button;

    public void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        jumpController.Jump();
    }
}
