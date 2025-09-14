using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterC : MonoBehaviour,IClickable
{
    private MeshRenderer _meshRenderer;
    private Material _material;
    private Color _opaque;
    private Color _transparent;
    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _material = GetComponent<Material>();
        _opaque = _material.color;
        _transparent = _material.color;
        _transparent.a = 0;
    }
    public void OnClick()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_material.DOColor(_transparent, 2.0f));
        sequence.AppendInterval(1.0f);
        sequence.Append(_material.DOColor(_opaque, 2.0f));

        sequence.Play();
    }

   
}
