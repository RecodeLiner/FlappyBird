using UnityEngine;

public class Initable<T> : MonoBehaviour
{
    public T Model;

    private bool _isInited = false;
    
    public void Init(T model)
    {
        if (_isInited)
            return; 
        
        Model = model;
        _isInited = true; 
        enabled = true; 
    }

    private void OnEnable()
    {
        if (_isInited == false)
        {
            enabled = false;
            return;
        }

        OnInitedEnable();
    }

    private void OnDisable()
    {
        if (_isInited)
            OnInitedDisable();
    }
    
    public virtual void OnInitedEnable() { }
    public virtual void OnInitedDisable() { } 
}
