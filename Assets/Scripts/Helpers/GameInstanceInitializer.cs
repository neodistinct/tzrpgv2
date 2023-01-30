using UnityEngine;

public class GameInstanceInitializer : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _characterPrefabs;
    
    [SerializeField]
    private Transform _characterPreviewPoint;

    private void Start()
    {
        GameInstance.getInstance().SetCharacterPrefabs(_characterPrefabs);
        GameInstance.getInstance().PreviewPoint = _characterPreviewPoint;
    }


}
