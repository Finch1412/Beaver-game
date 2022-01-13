using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManagerScript : MonoBehaviour
{

    public GameObject scoreText;

    public int logs = 0;

    private Animator animator;

    void Awake()
    {

        animator = GetComponent<Animator>();

    }

    // Start is called before the first frame update
    void Start()
    {  

        scoreText.GetComponent<Text>().text = "0";

    }

    // Update is called once per frame
    void Update()
    {
        //allows animator to read the logs perameter as the correct variable
        animator.SetInteger("logs", logs);

    }

}
