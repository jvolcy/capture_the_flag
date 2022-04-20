using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public CanonCtrl canonCtrl;
    public float Angle = 20f;
    public float SmallAngleIncrement = 1f;
    public float LargeAngleIncrement = 10f;
    public float MinAngle = 0f;     //tbi
    public float MaxAngle = 90f;    //tbi
    public float TNT = 500f;
    public float SmallTNTIncrement = 5f;
    public float LargeTNTIncrement = 50f;
    public float MinTNT = 100f;     //tbi
    public float MaxTNT = 2000f;    //tbi
    public float MinWind = -20f;    //tbi
    public float MaxWind = 20f;     //tbi
    public List <GameObject> Levels;
    public TMP_Text TNTText;
    public TMP_Text AngleText;

    // Start is called before the first frame update
    void Start()
    {
        updateDisplay();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void updateDisplay()
    {
        canonCtrl.Angle = Angle;
        canonCtrl.TNT = TNT;
        TNTText.text = "TNT: " + TNT.ToString();
        AngleText.text = "Angle: " + Angle.ToString();
        canonCtrl.UpdateCanonOnScreen();
    }

    public void TNTUp1() { TNT += SmallTNTIncrement; updateDisplay(); }
    public void TNTUp2() { TNT += LargeTNTIncrement; updateDisplay(); }
    public void TNTDown1() { TNT -= SmallTNTIncrement; updateDisplay(); }
    public void TNTDown2() { TNT -= LargeTNTIncrement; updateDisplay(); }

    public void AngleUp1() { Angle += SmallAngleIncrement; updateDisplay(); }
    public void AngleUp2() { Angle += LargeAngleIncrement; updateDisplay(); }
    public void AngleDown1() { Angle -= SmallAngleIncrement; updateDisplay(); }
    public void AngleDown2() { Angle -= LargeAngleIncrement; updateDisplay(); }

    public void Fire() { canonCtrl.Fire(); }
}
