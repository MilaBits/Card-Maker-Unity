using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class Card : ScriptableObject {
    // Basic Information
    public string Name;
    public string Summary;
    public string Description;
    [Space]
    // Rolls
    public string RollTarget;
    public RollType RollType;
    public string RollText;
    [Space]
    // Critical Effects
    public CriticalType CriticalType;
    public string FirstEffect;
    public string SecondEffect;
    [Space]
    // Crew
    public Role MainRole;
    public Role SecondaryRoles;
    public int Cost;
    [Space]
    // Image
    public Image Image;
}