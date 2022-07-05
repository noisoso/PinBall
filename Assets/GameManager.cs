using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Ita;
    private Vector3 ItaPos;
    public GameObject MainCamera;
    private Vector3 sub = new Vector3(0, 12, -5.2f);
    private Vector3 main = new Vector3(10.01f, 11.74f, -5.76f);
    private int z = 1;
    

    // Start is called before the first frame update
    void Start()
    {

        ItaPos = Ita.transform.position;
        Invoke("Reset", 3.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Instantiate(Ball, new Vector3(1.67f, 2.8f, 4), Quaternion.identity);
            Instantiate(Ball, new Vector3(11, 3, 4), Quaternion.identity);
        }

        if (Input .GetKeyDown(KeyCode.A ))
        {
            Ita.transform.position = new Vector3(0, -1.2f, 0);
        }
        Reset();

        if (Input .GetKeyUp (KeyCode.K ))
        {
            Debug.Log("aaaa");
        }

        if (Input .GetKeyDown(KeyCode.Space))
        {

            z += 1;

            if (z % 2==0)
            {
                MainCamera.transform.position = main;
            }
            else
            {
                MainCamera.transform.position = sub;
            }
        }


    }

    private void Reset()
    {

        if (Input.GetKeyUp(KeyCode.A))
        {
            Ita.transform.position = ItaPos; ;
        }
    }

}
