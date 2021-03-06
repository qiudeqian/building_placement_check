﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingHelper 
{
    public static void SetBuildingAlpha(GameObject building,float alpha)
    {
        //return;
        Renderer[]  renders = building.GetComponentsInChildren<Renderer>();
        foreach (var render in renders)
        {
            Color color = render.material.color;
            color.a = alpha;
            render.material.color = color;
        }
    }

    public static void SetBuildingLayer(GameObject building,string layerName)
    {
        building.layer = LayerMask.NameToLayer(layerName);
    }

    public static Rect MakeRectOfCollider(Collider col)
    {
        Rect r = new Rect(col.bounds.center.x - col.bounds.extents.x,
                        col.bounds.center.z - col.bounds.extents.z,
                        col.bounds.size.x, col.bounds.size.z);
        return r;
    }
}
