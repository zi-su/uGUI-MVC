using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIDialogController : UIControllerBase<UIDialogViewer, UIDialogModel>
{
    [SerializeField] TMPro.TextMeshProUGUI TextMeshProUGUI;
    

    // Start is called before the first frame update
    void Start()
    {
        _modelBase.Text = TextMeshProUGUI.text;
        _viewerBase._textMeshProUGUI = TextMeshProUGUI;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        if (Input.GetKeyDown(KeyCode.G))
        {
            SetText("HogeFuga");
        }
    }

    public void SetText(string text)
    {
        _modelBase.Text = text;
    }
}
