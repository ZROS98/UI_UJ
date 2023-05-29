using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [field: SerializeField]
    private GameObject ContentPrefab { get; set; }
    [field: SerializeField]
    private GameObject UIParent { get; set; }
    [field: SerializeField]
    private List<GameObject> ContentPrefabCollection { get; set; }

    private int MaxContentPrefabCollectionCount { get; set; } = 4;

    public void AddContentPrefab ()
    {
        if (ContentPrefabCollection.Count >= MaxContentPrefabCollectionCount)
        {
            return;
        }
        
        GameObject currentContentPrefab = Instantiate(ContentPrefab, UIParent.transform);
        ContentPrefabCollection.Add(currentContentPrefab);
    }

    public void RemoveContentPrefab ()
    {
        if (ContentPrefabCollection.Count <= 0)
        {
            return;
        }

        GameObject targetObject = ContentPrefabCollection[ContentPrefabCollection.Count - 1];
        ContentPrefabCollection.Remove(targetObject);
        Destroy(targetObject);
    }
}
