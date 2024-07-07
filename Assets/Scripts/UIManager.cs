using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private GameObject campPanel;
    [SerializeField] private GameObject collectionPanel;
    [SerializeField] private GameObject listCollectionPanel;
    [SerializeField] private GameObject detailPanel;
    [SerializeField] private GameObject nestPanel;
    [SerializeField] private GameObject infoPanel;

    void Start()
    {
        ShowMainPanel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMainPanel()
    {
        mainPanel.SetActive(true);
        campPanel.SetActive(false);
        collectionPanel.SetActive(false);
        listCollectionPanel.SetActive(false);
        detailPanel.SetActive(false);
        nestPanel.SetActive(false);
        infoPanel.SetActive(false);
    }
    
    public void ShowCampPanel()
    {
        mainPanel.SetActive(false);
        campPanel.SetActive(true);
        collectionPanel.SetActive(false);
        listCollectionPanel.SetActive(false);
    }

    public void ShowCollectionPanel()
    {
        mainPanel.SetActive(false);
        campPanel.SetActive(false);
        collectionPanel.SetActive(true);
        listCollectionPanel.SetActive(false);
    }

    public void ShowListCollectionPanel()
    {
        listCollectionPanel.SetActive(true);
    }

    public void HideListCollectionPanel()
    {
        listCollectionPanel.SetActive(false);
    }

    public void ShowDetailPanel()
    {
        detailPanel.SetActive(true);
    }

    public void HideDetailPanel()
    {
        detailPanel.SetActive(false);
    }

    public void ShowNestPanel()
    {
        nestPanel.SetActive(true);
    }

    public void HideNestPanel()
    {
        nestPanel.SetActive(false);
    }

    public void ShowInfoPanel()
    {
        infoPanel.SetActive(true);
    }

    public void HideInfoPanel()
    {
        infoPanel.SetActive(false); 
    }
}
