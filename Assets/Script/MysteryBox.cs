using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryBox : MonoBehaviour, IKrockable
{
    DrivingMovement driving;
    public GameObject mysteryBoxPrefab;
    private void Start()
    {
        driving = FindObjectOfType<DrivingMovement>();
        Instantiate(mysteryBoxPrefab, transform.position, transform.rotation);
    }
    

    // Start is called before the first frame update
    public void Krockad()
    {
           
    }
}
