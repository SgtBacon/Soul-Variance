using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CharacterSelect : MonoBehaviour
{
    public GameObject LevelSelectPanel;   //Open new panel for level select to lessen number of times objects are saved between scenes
    public GameObject CharacterSelectPanel;
    public GameObject SelectedChar;

    //Player picks character
    //Call Auto_Selection and Pass that character into Auto_Selection
    //Therefore cause game to pick random character, excluding random character
    //Load an overlay for picking level, send both characters to chosen level
    public void PlayerSelect(Button b)
    {
        Auto_Select(b.name);
    }
    public void Auto_Select(string SelectedChar)
    {
        //Create an array of all characters
        //Remove character selected by Player/Lessen chance of them being selected by computer
        OpenLevelSelect();
    }
    public void OpenLevelSelect()
    {
        if (CharacterSelectPanel.activeInHierarchy)
        {
            CharacterSelectPanel.SetActive(false);
            LevelSelectPanel.SetActive(true);
        }
        else
        {
            LevelSelectPanel.SetActive(false);
            CharacterSelectPanel.SetActive(true);
        }
    }

    public void SelectLevel(Button b)
    {
        SceneManager.LoadScene(b.name);
    }
}
