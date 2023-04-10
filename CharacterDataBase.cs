using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterDataBase: ScriptableObject
{
    public Characters[] character;
    public int CharacterCount
    {
        get 
        { 
            return character.Length; 
        }
    }
    public Characters GetCharacters(int index)
    { 
        return character[index]; 
    }
}
