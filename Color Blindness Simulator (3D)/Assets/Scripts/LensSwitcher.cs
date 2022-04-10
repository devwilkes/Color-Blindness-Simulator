using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LensSwitcher : MonoBehaviour
{
    public Button complete;
    public Button reset;
    public Selectable RG;
    public Selectable BY;
    public TMP_Text Textbox;
    public FilterSwitcher swap;

    void Start()
    {
        var RGdropdown = transform.GetComponent<TMP_Dropdown>();
        var BYdropdown = transform.GetComponent<TMP_Dropdown>();

        RGdropdown.options.Clear();
        BYdropdown.options.Clear();

        List<string> RGitems = new List<string>();
        List<string> BYitems = new List<string>();

        RGitems.Add("Deuteranomaly");
        RGitems.Add("Protanomaly");
        RGitems.Add("Deuteranopia");
        RGitems.Add("Protanopia");

        BYitems.Add("Tritanomaly");
        BYitems.Add("Tritanopia");

        foreach (var item in RGitems)
        {
            RGdropdown.options.Add(new TMP_Dropdown.OptionData() { text = item });
        }

        DropdownItemSelected(RGdropdown);
        RGdropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(RGdropdown); });

        foreach (var item in BYitems)
        {
            BYdropdown.options.Add(new TMP_Dropdown.OptionData() { text = item });
        }

        DropdownItemSelected(BYdropdown);
        BYdropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(BYdropdown); });
    }

    void DropdownItemSelected(TMP_Dropdown dropdown)
    {
        int index = dropdown.value;
        Textbox.text = dropdown.options[index].text;
        
    }
    public void On_Complete_Button_Click()
    {
        swap.Complete();

    }
    public void On_Reset_Button_Click()
    {
        swap.Reset();
    }
}
