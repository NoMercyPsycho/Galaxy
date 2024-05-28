using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int ring;
    public TextMeshProUGUI bestScoreText;
    public TextMeshProUGUI have;
    private GameObject[] rings;
    public static int countRings = 0;

    private void Start()
    {
        rings = GameObject.FindGameObjectsWithTag("Ring");
        ring = rings.Length;
        have.text = ring.ToString();
        bestScoreText.text = countRings.ToString();
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ring"))
        {
            countRings++;
            ring--;
            Destroy(other.gameObject);
            bestScoreText.text = countRings.ToString();
            have.text = ring.ToString();
        }
    }
}