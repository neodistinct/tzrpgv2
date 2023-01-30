using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameHUDWidget : MonoBehaviour
{   
    public void GoBack()
    {
        SceneManager.LoadScene("CharacterSelector");
    }
}
