using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [Header("Inventory")]
    public List<Image> _inventorySlots;
    public List<Image> _remainingSlots;
    [Header("SummonTable")]
    public List<Image> _summonTableSlots;
    public List<Image> _remainingSummonSlots;
    int index;
    [Header("Collectible")]
    public Sprite _empty_box;
    public List<Items> _item;
    int NumberOfItemToCollect;
    int RoomCountBeforeBoss;
    public int RoomCount;
    public bool BattleMod = false;
    [Header("GameSection")]
    public List<GameObject> GameSection;
    public GameObject BossSection;
    public GameObject StartSection;
    public Animator FadeScreenObject;
    [SerializeField] GameObject NextSection;
    [SerializeField] GameObject CurrentSection;
    void Start()
    {
        CurrentSection = StartSection;
    }

    public void ChangeRoom()
    {
        RoomCountBeforeBoss++;
        Fader();
        if (RoomCountBeforeBoss == 5)
        {
            NextSection = BossSection;
            RoomCountBeforeBoss = 0;
        }
        else
        {
            NextSection = GameSection[Random.Range(0, GameSection.Count)];
        }

        RoomCount++;

    }
    public void CollectItem(SpriteRenderer _renderer)
    {
        _renderer.sprite = _empty_box;
    }
    public void LoadSection()
    {
        Destroy(CurrentSection);
        Instantiate(NextSection, Vector3.zero, Quaternion.identity);
        CurrentSection = NextSection;
    }
    void Fader()
    {
        FadeScreenObject.Play("fade");
    }
    public void SetToInventory(Sprite _sprite) // => item du coffre vers inventaire
    {
        _remainingSlots.Clear();
        SetList();
        if (_remainingSlots.Count > 0)
        {
            _remainingSlots[0].sprite = _sprite;
            _remainingSlots[0].SetNativeSize();
        }
    }
    public void SetItemToTable(Image _image)
    {
        _remainingSummonSlots.Clear();
        foreach (Image _img in _summonTableSlots)
        {
            if (_img.sprite == null)
            {
                _remainingSummonSlots.Add(_img);
            }
        }
        if(_remainingSummonSlots.Count>0 && _remainingSummonSlots.Count < 4)
        {
            _remainingSummonSlots[0].sprite = _image.sprite;
            _remainingSummonSlots[0].SetNativeSize();
            _image.sprite = null;
        }
    }
    void SetList()
    {
        foreach (Image _img in _inventorySlots)
        {
            if (_img.sprite == null)
            {
                _remainingSlots.Add(_img);
            }
        }
        
    }
    public void RecoverItem(Image _image) // table de fusion vers inventaire
    {
        _remainingSlots.Clear();
        SetList();
        if (_remainingSlots.Count > 0 && _remainingSlots.Count<16)
        {
            _remainingSlots[0].sprite = _image.sprite;
            _remainingSlots[0].SetNativeSize();
            _image.sprite = null;
        }
    }
}
