using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    public int Love = 0;
    public int Cleanliness = 50;
    public int Fullness = 50;
    public int[] foodStock = { 1, 1, 1, 1, 0 }; // ���� �κ��丮 �������
    public bool isFoodSpawn = false;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}