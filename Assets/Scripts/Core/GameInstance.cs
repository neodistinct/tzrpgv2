using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInstance
{
    private static GameInstance _instance;

    private GameObject[] _characterPrefabs;
    private GameObject _currentPlayerModel;

    private Transform _previewPoint;

    public GameObject PlayerModel { get { return _currentPlayerModel; } }
    public Transform PreviewPoint { get { return _previewPoint; }  set => _previewPoint = value; }
    private GameInstance() { }

    public static GameInstance getInstance()
    {
        if (_instance == null)
            _instance = new GameInstance();
        return _instance;
    }

    internal void SetCharacterPrefabs(GameObject[] characterPrefabs)
    {
        _characterPrefabs = characterPrefabs;
    }

    public void PickRandomCharacter()
    {
        _currentPlayerModel = GameplayStatics.PickRandomPrefab(_characterPrefabs);

        if (_previewPoint.childCount > 0) 
            GameObject.Destroy(_previewPoint.GetChild(0).gameObject);

        GameObject.Instantiate(_currentPlayerModel, _previewPoint);
    }

    public void SpawnCharacter(Transform spawnPoint, bool addGameBehavior = false)
    {

        if (_currentPlayerModel == null)
        {
            Debug.LogError("Character model was not set. Initialize Game Instance properly!");
            return;
        }

        GameObject Character = GameObject.Instantiate(_currentPlayerModel, spawnPoint);
        if(addGameBehavior) Character.AddComponent<CharacterBehavior>();
    }

    public void LoadGameScene()
    {
        if (_currentPlayerModel)
            SceneManager.LoadScene("Game");
        else
            Debug.LogWarning("Character model was not set. Generate it before proceeding.");
    }
}
