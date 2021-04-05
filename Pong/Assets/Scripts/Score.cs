using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private Collider2D Spawn1;
    [SerializeField] private Collider2D Spawn2;

    [SerializeField] private GameObject Score1;
    [SerializeField] private GameObject Score2;

    private int playerScore1 = 0;
    private int playerScore2 = 0;

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == Spawn2)
        {
            playerScore1++;
            Score1.GetComponent<TextMeshProUGUI>().text = playerScore1.ToString();
            StartCoroutine(ResetPosition());
        }
        else if (collision == Spawn1)
        {
            playerScore2++;
            Score2.GetComponent<TextMeshProUGUI>().text = playerScore2.ToString();
            StartCoroutine(ResetPosition());           
        }
    }

    private IEnumerator ResetPosition()
    {
        yield return new WaitForSeconds(0.5f); 
        transform.position = startPos;
    }
}
