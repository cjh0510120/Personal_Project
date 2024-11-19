using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public GameObject Stage1;
    public GameObject Stage2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stage1.SetActive(true);
        Stage2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
