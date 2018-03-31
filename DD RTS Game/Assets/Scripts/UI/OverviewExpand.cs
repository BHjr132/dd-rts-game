using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverviewExpand : MonoBehaviour {

    [Tooltip("Default Expanded Setting")]
    public bool expanded = false;

    [Space]

    [Header("Game Objects")]
    public GameObject Gold;
    public GameObject Gems;
    public GameObject Iron;
    public GameObject Tools;
    public GameObject Coats;
    public GameObject Firewood;
    public GameObject Weapons;
    public GameObject Armor;
    public GameObject Faith;

    [Header("UI Elements")]
    public GameObject ExpandButton;
    public GameObject OverviewSmall;
    public GameObject OverviewLarge;

    void Start () {
        Gold.SetActive(expanded);
        Gems.SetActive(expanded);
        Iron.SetActive(expanded);
        Tools.SetActive(expanded);
        Coats.SetActive(expanded);
        Firewood.SetActive(expanded);
        Weapons.SetActive(expanded);
        Armor.SetActive(expanded);
        Faith.SetActive(expanded);

        ExpandButton.transform.eulerAngles = new Vector3(180f, 0f, 0f);
        OverviewSmall.SetActive(true);
        OverviewLarge.SetActive(false);
    }
	
	public void ExpandMenu () {
		if (expanded == false)
        {
            expanded = true;

            Gold.SetActive(true);
            Gems.SetActive(true);
            Iron.SetActive(true);
            Tools.SetActive(true);
            Coats.SetActive(true);
            Firewood.SetActive(true);
            Weapons.SetActive(true);
            Armor.SetActive(true);
            Faith.SetActive(true);

            ExpandButton.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            OverviewSmall.SetActive(false);
            OverviewLarge.SetActive(true);
        } else
        {
            expanded = false;

            Gold.SetActive(false);
            Gems.SetActive(false);
            Iron.SetActive(false);
            Tools.SetActive(false);
            Coats.SetActive(false);
            Firewood.SetActive(false);
            Weapons.SetActive(false);
            Armor.SetActive(false);
            Faith.SetActive(false);

            ExpandButton.transform.eulerAngles = new Vector3(180f, 0f, 0f);
            OverviewSmall.SetActive(true);
            OverviewLarge.SetActive(false);
        }
	}
}
