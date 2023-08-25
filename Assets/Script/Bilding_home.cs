using UnityEngine;
using UnityEngine.UI;

public class Bilding_home : MonoBehaviour
{
    [SerializeField]
    GameObject _prefab; //Ссылка на ваш префаб

    [SerializeField]
    Button _button;

    void Start()
    {
        _button.onClick.AddListener(Spawn); //здесь мы добавляем к событию onClick нашей кнопки слушателя Spawn
    }

    void Spawn()
    {
        _button.onClick.RemoveListener(Spawn); 
        Instantiate(_prefab, new Vector3(-778, 3, -355), Quaternion.identity);
    }
}