using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PrefabCreator : MonoBehaviour
{
    [SerializeField] private GameObject dragonprefab;
    [SerializeField] private Vector3 prefabOffset;

    private GameObject dragon;
    private ARTrackedImageManager aRTrackedImageManager;

    private void OnEnable()
    {
        // Finds the ARTrackedImageManager component to track images in the AR environment.
        aRTrackedImageManager = gameObject.GetComponent<ARTrackedImageManager>();

        // Registers the OnImageChanged event handler to respond to changes in tracked images.
        aRTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    private void OnImageChanged(ARTrackedImagesChangedEventArgs obj)
    {
        // For each newly detected AR image, instantiate a dragon prefab and adjust its position.
        foreach (ARTrackedImage image in obj.added)
        {
            dragon = Instantiate(dragonprefab, image.transform);
            dragon.transform.position += prefabOffset;
        }
    }
}
