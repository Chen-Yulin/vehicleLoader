using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralUI : MonoBehaviour
{
    // Start is called before the first frame update
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadJson()
    {
        GameObject loader = GameObject.Find("JsonReader");
        JsonReader jr = loader.GetComponent<JsonReader>();
        VehicleConstructor vc = loader.GetComponent<VehicleConstructor>();
        TMPro.TMP_Dropdown dropdown = transform.Find("Load").Find("Dropdown").gameObject.GetComponent<TMPro.TMP_Dropdown>();
        jr.SavesDir = dropdown.options[dropdown.value].text;
        jr.ReadJson();
        vc.PlaceVehicle(GameObject.Find("VehicleSpace").transform, SceneManager.GetActiveScene().name == "Editor");

    }

    public void DeleteVehicle()
    {
        GameObject space = GameObject.Find("VehicleSpace");
        if (space.transform.childCount!=0)
        {
            Destroy(space.transform.GetChild(0).gameObject);
        }
    }

    public void ToggleOrthographic()
    {
        Camera.main.orthographic = !Camera.main.orthographic;
    }
}
