using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ReadSavesList : MonoBehaviour
{
    public TMPro.TMP_Dropdown dropdown;
    private void ReadSavesDir(string dir)
    {
        string[] files = Directory.GetFiles(dir);
        dropdown.ClearOptions();
        foreach (string file in files)
        {
            dropdown.options.Add(new TMPro.TMP_Dropdown.OptionData(Path.GetFileName(file)));
        }
        dropdown.RefreshShownValue();
    }
    void Start()
    {
        dropdown = GetComponent<TMPro.TMP_Dropdown>();

        ReadSavesDir(Application.streamingAssetsPath + "/Saves/");

    }

}
