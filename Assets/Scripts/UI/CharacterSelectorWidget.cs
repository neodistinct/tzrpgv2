using UnityEngine;

public class CharacterSelectorWidget : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _characterPrefabs;

    public void Generate()
    {
        GameInstance.getInstance().PickRandomCharacter();
    }

    public void Play()
    {
        GameInstance.getInstance().LoadGameScene();
    }
}
