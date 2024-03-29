using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float MaxValue = 100;
    public Slider Healthbar;

    public GameObject PlayerUI;
    public GameObject GameOverUI;

    float _currentValue;

    void Start()
    {
        _currentValue = MaxValue;
        UpdateHealthbar();
    }

    public void TakeDamage(float damage)
    {
        _currentValue -= damage;
        if (_currentValue <= 0)
        {
            _currentValue = 0;
            GameOver();
        }
        UpdateHealthbar();
    }

    public void AddHealth(float amount)
    {
        //Прибавить к текущему здоровью значение amount
        //Если текущее здоровье больше, чем максимальное значение
        {
            //Текущее здоровье = максимальное значение
        }
        //Обновить полоску здоровья
    }

    void UpdateHealthbar()
    {
        Healthbar.value = _currentValue / MaxValue;
    }

    void GameOver()
    {
        PlayerUI.SetActive(false);
        GameOverUI.SetActive(true);
        GetComponent<Player>().enabled = false;
        GetComponent<CameraController>().enabled = false;
    }
}
