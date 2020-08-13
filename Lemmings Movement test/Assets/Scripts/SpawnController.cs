using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public int boiNum = 0;
    public Transform spawner;
    public BoiAgent boiPrefab;
    List<BoiAgent> bois = new List<BoiAgent>();
    public Behaviours behaviours;




    void Start()
    {
        StartCoroutine(Spawn());
    }


    IEnumerator Spawn()
    {
        
        for (int i = 0; i < boiNum; i++)
        {
            BoiAgent newBoi = Instantiate
             (
                 boiPrefab,
                 spawner.position,
                 spawner.rotation
             );
            newBoi.name = "Boi" + i;
            bois.Add(newBoi);
            yield return new WaitForSeconds(1);
        }
        
    }
}
