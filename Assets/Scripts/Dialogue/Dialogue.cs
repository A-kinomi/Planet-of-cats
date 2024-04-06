using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inspired by https://github.com/Brackeys/Dialogue-System

namespace Dialogue
{
[Serializable]
public class Dialogue
{
    public string name;
    [TextArea(3, 10)]
    public string[] sentences;
}
}