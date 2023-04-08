using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TrapSprite{
    [SerializeField] private Color _color;
    [SerializeField] private Sprite _sprite;

    public Color Color { get { return _color; } }
    public Sprite Sprite { get { return _sprite; } }
}
