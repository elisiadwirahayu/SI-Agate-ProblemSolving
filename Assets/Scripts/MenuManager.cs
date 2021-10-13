using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Button Menu1;
    [SerializeField] private Button Menu2;
    [SerializeField] private Button Menu3;
    [SerializeField] private Button Menu4;
    [SerializeField] private Button Menu5;
    [SerializeField] private Button Menu6;
    [SerializeField] private Button Menu7;
    [SerializeField] private Button Menu8;
    [SerializeField] private Button Menu9;

    private void Start()
    {
        Menu1.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });

        Menu2.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(2);
        });

        Menu3.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(3);
        });

        Menu4.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(4);
        });

        Menu5.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(5);
        });

        Menu6.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(6);
        });

        Menu7.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(7);
        });

        Menu8.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(8);
        });

        Menu9.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(9);
        });
    }

}