using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    int MaxItems = 5;
    int ItemsToSort;
    public List<GameObject> LootTable;
    public List<T> Shuffle<T>(List<T> _list)
    {
        for (int i = 0; i < _list.Count; i++)
        {
            T temp = _list[i];
            int randomIndex = Random.Range(i, _list.Count);
            _list[i] = _list[randomIndex];
            _list[randomIndex] = temp;
        }

        return _list;
    }

    public void GetItems()
    {
        Debug.Log("DO !!!");
        StartCoroutine(SortItem());
    }
    IEnumerator SortItem()
    {
        ItemsToSort = Random.Range(1, MaxItems);
        for (int i = 0; i < ItemsToSort; i++)
        {
            Shuffle(LootTable);
            GameObject.Instantiate(LootTable[Random.Range(0, LootTable.Count)], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.2f);
        }


    }
}
