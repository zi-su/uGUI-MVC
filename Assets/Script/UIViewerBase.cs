using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UIViewerBase
{
    protected UIModelBase _modelBase;
    public abstract void SetModel(UIModelBase model);
    public abstract void Update();
}
