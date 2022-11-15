using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

[CreateAssetMenu]
public class DialogueSequenceObject : ScriptableObject
{

    public SequenceClass[] sequence;

    public string[] responses;

    public DialogueSequenceObject[] branches;

}
