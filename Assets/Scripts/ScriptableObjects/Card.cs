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
    public Phase Phase;

    // Rolls
    public string RollTarget;
    public RollType RollType;
    public string RollText;
    
    // Critical Effects
    public CriticalType CriticalType;
    public string FirstEffect;
    public string SecondEffect;

    // Crew
    public Role MainRole;
    public List<Role> SecondaryRoles;
    public int Cost;

    // Image
    public Image Image;
}
