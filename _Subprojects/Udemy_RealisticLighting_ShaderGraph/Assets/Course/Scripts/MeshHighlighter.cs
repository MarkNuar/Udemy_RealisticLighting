﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class MeshHighlighter : MonoBehaviour
{
    private MeshRenderer originalMesh;
    [SerializeField]
    private MeshRenderer highlightedMesh;

    // Start is called before the first frame update
    void Start()
    {
        originalMesh = GetComponent<MeshRenderer>();
        EnableHighlight(false);
    }

    public void EnableHighlight(bool onOff)
    {
        if (highlightedMesh != null)
        {
            highlightedMesh.enabled = onOff;
            originalMesh.enabled = !onOff;
        }
    }

    private void OnMouseEnter()
    {
        EnableHighlight(true);
    }

    private void OnMouseExit()
    {
        EnableHighlight(false);
    }
}
