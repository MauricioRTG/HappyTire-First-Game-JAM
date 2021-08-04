using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Points : MonoBehaviour
{
    public static Points instance;

    public float boostTrigger = 15;
    [SerializeField]private float boostValue = 0;
    public string texto = "score: ";
    public float score;
    private float multiplicador = 2;
    private MoveTo player;
    private TextMeshProUGUI textObject;

    private void Awake()
    {
        textObject = GetComponent<TextMeshProUGUI>();
        player = FindObjectOfType<MoveTo>();

        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        boostValue += Time.deltaTime * multiplicador;
        score += Time.deltaTime * multiplicador;

        if (boostValue > boostTrigger)
        {
            if (player.constantSpeed <= 20)
                player.constantSpeed *= 1.05f;
            boostValue = 0;
        }
        
        textObject.text = texto + Mathf.RoundToInt(score);
    }
}
