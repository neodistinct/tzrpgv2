using UnityEngine;

public class GameModeInitializer : MonoBehaviour
{
    [SerializeField]
    private Transform _characterSpawnPoint;

    void Start()
    {
        if (!_characterSpawnPoint)
        {
            Debug.LogError("No spawn point set. Please set the character spawn point.");
            return;
        }

        GameInstance.getInstance().SpawnCharacter(_characterSpawnPoint, true);

    }

}
