using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDarts : MonoBehaviour
{
    [SerializeField] public GameObject[] darts;
    [SerializeField] public Vector3[] position;
    [SerializeField] public Vector3[] rotaion;
    // Start is called before the first frame update
    void Start()
    {
        if (darts.Length != position.Length || darts.Length != rotaion.Length) //TODO entfernen, only debug
        {
            Debug.Log("Error ->" +  darts.Length + "Darts and " + position.Length + "Positions" );
            return;
        }
        for (int i = 0; i < darts.Length; i++)
        {
            darts[i].GetComponent<dart>().dartNum = i;
            Instantiate(darts[i], position[i], Quaternion.Euler(rotaion[i]));
        }
    }

    public void replaceDart(int d)
    {
        Instantiate(darts[d], position[d], Quaternion.Euler(rotaion[d]));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
