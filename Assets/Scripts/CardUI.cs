using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardUI : MonoBehaviour {
    public TMP_InputField NameInput;
    public TMP_InputField SummaryInput;
    public TMP_InputField DescriptionInput;
    public TMP_Dropdown PhaseInput;
    
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
    public TMP_Dropdown SecondRoleInput;
    public TMP_InputField CostInput;

    [Space]
    public TMP_InputField ImageInput;

}
