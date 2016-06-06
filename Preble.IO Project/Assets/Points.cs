using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Points : MonoBehaviour
{

    public int PointsInt;
    public Text PointsText;
    public GameObject Bullet;
    public GameObject cube;
    void Start()
    {
        PointsInt = 0;
    }

    void OnTriggerEnter()
    {

        if (Bullet.tag == "Food")
        {
            PointsInt += 1;
            StartCoroutine(Killers());
        }
    }
    void Update()
    {
        PointsText.text = "Score  " + PointsInt;
    }

    IEnumerator Killers()
    {
        Destroy(Bullet);
        Destroy(cube);
        yield return new WaitForSeconds(1);
    }
}
