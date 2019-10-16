using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkManager : MonoBehaviour
{
    [SerializeField] public List<GameObject> chunkList = new List<GameObject>();
    [SerializeField] public List<GameObject> chunkOrder = new List<GameObject>();
    int currentChunk = 0;

    // 1: load North chunk, 0: load South Chunk
    public void LoadChunk(int dir)
    {
        if(dir == 1)
        {
            chunkList[currentChunk+1].SetActive(true);
            currentChunk++;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        // Deactivate all chunks after the first
        for (int i = 1; i < chunkList.Count; i++)
        {
            chunkList[i].SetActive(false); ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
