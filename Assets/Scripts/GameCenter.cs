using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCenter : MonoBehaviour
{
    [Serializable]
    public struct MinMax<T>
    {
        public T max;
        public T min;
    }

    //SINGLETON
    public static GameCenter Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
}
