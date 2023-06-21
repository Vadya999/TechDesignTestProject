using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private HitDetection _hitDetection;
    [SerializeField] private GameObject buttonNextSceneGameObject;
    [SerializeField] private Button buttonScene;

    [SerializeField] [Range(0,1)] private int sceneIndexToLoad;
        void Start()
        {
            _hitDetection.hitAction += InitializeButton;
            buttonNextSceneGameObject.SetActive(false);
            
            buttonScene.onClick.AddListener((() => {SceneManager.LoadScene(sceneIndexToLoad);}));
        }

        private void InitializeButton()
        {
            buttonNextSceneGameObject.SetActive(true);
        }

        private void OnDestroy()
        {
            _hitDetection.hitAction -= InitializeButton;
        }
}
