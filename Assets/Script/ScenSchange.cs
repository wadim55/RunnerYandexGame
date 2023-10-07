using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenSchange : MonoBehaviour
{
   
    
    public void OpenMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OpenG()
    {
        SceneManager.LoadScene("Game");
    }

}