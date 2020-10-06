using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDialogViewer : UIViewerBase
{
    
    public TMPro.TextMeshProUGUI _textMeshProUGUI { private get; set; }



    UIDialogModel _model;
    public override void SetModel(UIModelBase model)
    {
        _model = (UIDialogModel)model;
    }

    public override void Update()
    {
        _textMeshProUGUI.SetText(_model.Text);
    }
}
