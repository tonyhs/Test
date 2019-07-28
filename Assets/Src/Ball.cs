using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject[] numbers;
    // Start is called before the first frame update

    void Start()
    {
        if (GetComponent<Renderer>().material.color == new Color(0, 189 / 255f, 213 / 255f))
        {
            numbers[0].SetActive(true);
            for (int i = 1; i < numbers.Length; i++)
                numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(220 / 255f, 90 / 255f, 56 / 255f))
        {
            numbers[1].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 1)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(108 / 255f, 147 / 255f, 216 / 255f))
        {
            numbers[2].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 2)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(80 / 255f, 210 / 255f, 166 / 255f))
        {
            numbers[3].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 3)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(250 / 255, 187 / 255f, 48 / 255f))
        {
            numbers[4].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 4)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(226 / 255f, 163 / 255f, 161 / 255f))
        {
            numbers[5].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 5)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(205 / 255f, 144 / 255f, 211 / 255f))
        {
            numbers[6].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 6)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(118 / 255f, 201 / 255f, 83 / 255f))
        {
            numbers[7].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 7)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(227 / 255f, 129 / 255f, 56 / 255f))
        {
            numbers[8].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 8)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(155 / 255f, 111 / 255f, 200 / 255f))
        {
            numbers[9].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 9)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(118 / 255f, 80 / 255f, 163 / 255f))
        {
            numbers[10].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 10)
                    numbers[i].SetActive(false);
        }
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GetComponent<Renderer>().material.color == new Color(0, 189 / 255f, 213 / 255f))
        {
            numbers[0].SetActive(true);
            for (int i = 1; i < numbers.Length; i++)
                numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(220 / 255f, 90 / 255f, 56 / 255f))
        {
            numbers[1].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 1)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(108 / 255f, 147 / 255f, 216 / 255f))
        {
            numbers[2].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 2)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(80 / 255f, 210 / 255f, 166 / 255f))
        {
            numbers[3].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 3)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(250 / 255, 187 / 255f, 48 / 255f))
        {
            numbers[4].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 4)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(226 / 255f, 163 / 255f, 161 / 255f))
        {
            numbers[5].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 5)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(205 / 255f, 144 / 255f, 211 / 255f))
        {
            numbers[6].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 6)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(118 / 255f, 201 / 255f, 83 / 255f))
        {
            numbers[7].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 7)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(227 / 255f, 129 / 255f, 56 / 255f))
        {
            numbers[8].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 8)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(155 / 255f, 111 / 255f, 200 / 255f))
        {
            numbers[9].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 9)
                    numbers[i].SetActive(false);
        }
        else if (GetComponent<Renderer>().material.color == new Color(118 / 255f, 80 / 255f, 163 / 255f))
        {
            numbers[10].SetActive(true);
            for (int i = 0; i < numbers.Length; i++)
                if (i != 10)
                    numbers[i].SetActive(false);
        }
    }
}
