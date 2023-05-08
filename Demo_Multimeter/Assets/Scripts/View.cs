using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class View : MonoBehaviour
{

    [SerializeField] private TMP_Text MainLabel;
    [SerializeField] private TMP_Text SecondaryLabel;

    private Model model;
    void Start()
    {
        model = GetComponent<Model>();
        
    }

    public void RefreshLabel(string Value)
    {
        MainLabel.text = Value;
    }

    public void FillLabel(double VValue, double AValue, double VMinusValue, double RValue)
    {
        SecondaryLabel.text = $"V = {VValue}\r\nA = {AValue}\r\n- = {VMinusValue}\r\n? = {RValue}";
    }
}
