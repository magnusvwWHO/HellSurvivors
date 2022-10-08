using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TinkerWorX.AccidentalNoiseLibrary;

public class Generator : MonoBehaviour
{
    [SerializeField]
    private int width;
    public int Width {
        get {
            return width;
        }
        set {
            width = value;
        }
    }
    [SerializeField]
    private int height;
    public int Height {
        get {
            return height;
        }
        set {
            height = value;
        }
    }
    [SerializeField]
    private int terrainOctaves;
    public int TerrainOctaves {
        get {
            return terrainOctaves;
        }
        set {
            terrainOctaves = value;
        }
    }

    private ImplicitFractal HeightMap;
}
