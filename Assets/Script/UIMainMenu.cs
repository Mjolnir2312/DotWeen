using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button starButton;
    [SerializeField] private Button hightscoreButton;
    [SerializeField] private Button shopButton;
    [SerializeField] private Button settingsButton;

    [SerializeField] private Transform starContainer;
    [SerializeField] private Transform hightscoreContainer;
    [SerializeField] private Transform shopContainer;
    [SerializeField] private Transform settingsContainer;

    private void Awake()
    {
        starButton?.onClick.AddListener(OnStartPressed);
        hightscoreButton?.onClick.AddListener(OnHighscorePressed);
        shopButton?.onClick.AddListener(OnShopPressed);
        settingsButton?.onClick.AddListener(OnSettingsPressed);
    }

    private void OnDestroy()
    {
        starButton?.onClick.RemoveListener(OnStartPressed);
        hightscoreButton?.onClick.RemoveListener(OnHighscorePressed);
        shopButton?.onClick.RemoveListener(OnShopPressed);
        settingsButton?.onClick.RemoveListener(OnSettingsPressed);
    }

    private void OnStartPressed()
    {

    }

    private void OnHighscorePressed()
    {

    }

    private void OnShopPressed()
    {

    }

    private void OnSettingsPressed()
    {

    }
}
