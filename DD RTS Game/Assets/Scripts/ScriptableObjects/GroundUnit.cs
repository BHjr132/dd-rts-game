using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ground Unit", menuName = "Ground Unit")]
public class GroundUnit : ScriptableObject {

    public enum unitType
    {
        melee, ranged, cavalry, siege
    }
    public enum mainWeapon
    {
        sword, axe, bow, siege, unarmed
    }
    public enum unitTest
    {
        
    }

    [Header("Unit Name & Description")]
	public new string name;
    public string description;

    [Header("Graphics")]
    public Sprite Icon;
    public GameObject Model;

    [Header("Unit Settings")]
    public unitType UnitType;
    public bool uniqueUnit;
    public mainWeapon MainWeapon;
    public bool armored;
    public float speed;
    public float trainingTime;

}
