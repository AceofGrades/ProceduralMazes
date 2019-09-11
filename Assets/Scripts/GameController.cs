using System;
using UnityEngine;

[RequireComponent(typeof(MazeGenerator))]

public class GameController : MonoBehaviour
{
    private MazeGenerator generator;

    void Start()
    {
        generator = GetComponent<MazeGenerator>();
    }
}
