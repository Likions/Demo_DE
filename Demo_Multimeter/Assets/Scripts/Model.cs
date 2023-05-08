using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    private int RValue = 1000;
    private int PValue = 400;
    private double VMinusValue = 0.01;

    private View view;

    

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<View>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void solution(float ZRotation)
    {
        double AValue = Math.Sqrt(RValue * PValue);
        double VValue = PValue / AValue;

        double resultA = Math.Round(AValue, 2);
        double resultV = Math.Round(VValue, 2);

        if (ZRotation >= 0 && ZRotation < 90)
        {
            view.RefreshLabel(RValue.ToString());
        }
        if (ZRotation >= 90 && ZRotation < 180)
        {
            view.RefreshLabel(resultA.ToString());
        }
        if (ZRotation >= 180 && ZRotation < 270)
        {
            view.RefreshLabel(VMinusValue.ToString());
        }
        if (ZRotation >= 270 && ZRotation <= 360)
        { 
            view.RefreshLabel(resultV.ToString());
        }
        view.FillLabel(resultV, resultA, VMinusValue, RValue);
    }
}
