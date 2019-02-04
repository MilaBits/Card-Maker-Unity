using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

public class CardUI : MonoBehaviour {
    [SerializeField]
    private Card Card;

    [Space]
    public TMP_InputField NameInput;

    public TMP_InputField SummaryInput;
    public TMP_InputField DescriptionInput;

    [Space]
    public TMP_InputField RollTargetInput;

    public TMP_Dropdown RollTypeInput;
    public TMP_InputField RollTextInput;

    [Space]
    public TMP_Dropdown CriticalEffectTypeInput;

    public TMP_InputField FirstEffectInput;
    public TMP_InputField SecondEffectInput;

    [Space]
    public TMP_Dropdown MainRoleInput;

    public CrewSelector SecondRoleInput;
    public TMP_InputField CostInput;

    [Space]
    public TMP_InputField ImageInput;

    private void Start() {
        SetupDropdowns();

        UpdateCard(Card);
    }

    private void SetupDropdowns() {
        RollTypeInput.AddOptions(Enum.GetNames(typeof(RollType)).ToList());
        CriticalEffectTypeInput.AddOptions(Enum.GetNames(typeof(CriticalType)).ToList());
        MainRoleInput.AddOptions(Enum.GetNames(typeof(Role)).ToList());
    }

    public void UpdateCard(Card card) {
        Card = card;

        UpdateUI();
    }

    public void SetName(string value) {
        Debug.Log("Name changed");
        Card.Name = value;
    }

    public void SetSummary(string value) {
        Card.Summary = value;
    }

    public void SetDescription(string value) {
        Card.Description = value;
    }

    public void SetRollTarget(string value) {
        Card.RollTarget = value;
    }

    public void SetRollType(int value) {
        Card.RollType = (RollType) value;
    }

    public void SetRollText(string value) {
        Card.RollText = value;
    }

    public void SetCriticalEffectType(int value) {
        Card.CriticalType = (CriticalType) value;
    }

    public void SetFirstEffect(string value) {
        Card.FirstEffect = value;
    }

    public void SetSecondEffect(string value) {
        Card.SecondEffect = value;
    }

    public void SetMainRole(int value) {
        Card.MainRole = (Role) value;
    }

    public void SetSecondaryRoles(Role value) {
        Debug.Log("Setting: " + value);
        Card.SecondaryRoles = value;
    }

    public void SetCost(string value) {
        Card.Cost = Convert.ToInt16(value);
    }

    public void SetImage(string value) {
//        Card.Image = value;
    }

    public void UpdateUI() {
        NameInput.text = Card.Name;
        SummaryInput.text = Card.Summary;
        DescriptionInput.text = Card.Description;

        RollTargetInput.text = Card.RollTarget;
        RollTypeInput.value = (int) Card.RollType;
        RollTextInput.text = Card.RollText;

        CriticalEffectTypeInput.value = (int) Card.CriticalType;
        FirstEffectInput.text = Card.FirstEffect;
        SecondEffectInput.text = Card.SecondEffect;

        MainRoleInput.value = (int) Card.MainRole;
        SecondRoleInput.SetValue(Card.SecondaryRoles);
        CostInput.text = Card.Cost.ToString();

        // TODO: Figure out nice way to handle images.
//        ImageInput.text = Card.Image.name;
    }
}