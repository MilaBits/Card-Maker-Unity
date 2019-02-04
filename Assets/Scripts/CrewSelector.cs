using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CrewSelector : MonoBehaviour {

    private Role roles;

    [SerializeField]
    private Toggle pilotToggle;
    [SerializeField]
    private Toggle scienceToggle;
    [SerializeField]
    private Toggle gunnerToggle;
    [SerializeField]
    private Toggle captainToggle;
    [SerializeField]
    private Toggle mageToggle;
    [SerializeField]
    private Toggle engineerToggle;
    
    [Space]
    public OnRoleChangeEvent OnValueChanged;

    public void ValueChanged(int value) {
        roles ^= (Role)value;
        OnValueChanged.Invoke(roles);
    }

    public void SetValue(Role role) {
        roles = role;
        if (role.HasFlag(Role.Mage)) mageToggle.SetIsOnWithoutNotify(true);
        if (role.HasFlag(Role.Pilot)) pilotToggle.SetIsOnWithoutNotify(true);
        if (role.HasFlag(Role.Gunner)) gunnerToggle.SetIsOnWithoutNotify(true);
        if (role.HasFlag(Role.Captain)) captainToggle.SetIsOnWithoutNotify(true);
        if (role.HasFlag(Role.Engineer)) engineerToggle.SetIsOnWithoutNotify(true);
        if (role.HasFlag(Role.ScienceOfficer)) scienceToggle.SetIsOnWithoutNotify(true);
    }
}
