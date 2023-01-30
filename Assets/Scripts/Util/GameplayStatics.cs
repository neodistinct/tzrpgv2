using UnityEngine;

public static class GameplayStatics
{
    public static GameObject PickRandomPrefab(GameObject[] prefabs)
    {
        GameObject result = null;

        if (prefabs != null && prefabs.Length > 0)
        {
            int randomIndex = Random.Range(0, prefabs.Length - 1);
            result = prefabs[randomIndex];
        }

        return result;
    }
}
