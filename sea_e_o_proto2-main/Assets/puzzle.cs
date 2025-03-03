using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle : MonoBehaviour
{
    public bool completed;
    public GameObject Puzzlemanager;
    // Start is called before the first frame update
    void Start()
    {
        completed = false;       
    }

    // Update is called once per frame
    void Update()
    {
        completed = Puzzlemanager.GetComponent<PuzzleManager>().puzzleComplete;
    }
}
