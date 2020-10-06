using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UIControllerBase<T,U> : MonoBehaviour where T:UIViewerBase,new() where U:UIModelBase,new()
{
    protected T _viewerBase;
    protected U _modelBase;

    private void Awake()
    {
        _modelBase = new U();
        _viewerBase = new T();
        _viewerBase.SetModel(_modelBase);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        _viewerBase.Update();
    }
}
