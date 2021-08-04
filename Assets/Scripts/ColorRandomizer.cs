using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandomizer : MonoBehaviour
{
    [Tooltip("ACTIVA EL MODO DEBUG. TECLA ESPACIO PARA CAMBIAR COLOR EN REALTIME!!!")]
    public bool debug = false;

    private MeshRenderer myRenderer;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        AplicarMaterial();
    }

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AplicarMaterial();
        }
    }

    public void AplicarMaterial ()
    {
        for (int i = 0; i < myRenderer.materials.Length; i++)
        {
            Color ventanasColor = Random.ColorHSV(0.45f,0.55f , 0.7f,1 , 0.6f,0.9f);
            Color maderaColor = Random.ColorHSV(0,1 , 0,0.1f , 0.6f,0.9f);
            Color tejasColor = Random.ColorHSV(0,1 , 0.1f,0.6f , 0f,0.2f);
            Color paredColor = Random.ColorHSV(0,1 , 0.3f,0.6f , 0.4f,1);
            Color brickColor = Random.ColorHSV(0,1 , 0.3f,0.6f , 0.4f,1);


            switch (myRenderer.materials[i].name)
            {
                case "Ventanas_Color (Instance)":
                    myRenderer.materials[i].SetColor("Color_F24BD3BC", ventanasColor);
                    break;
                case "Madera_Color (Instance)":
                    myRenderer.materials[i].SetColor("Color_F24BD3BC", maderaColor);
                    break;
                case "Tejas_Color (Instance)":
                    myRenderer.materials[i].SetColor("Color_F24BD3BC", tejasColor);
                    break;
                case "Pared_Color (Instance)":
                    myRenderer.materials[i].SetColor("Color_F24BD3BC", paredColor);
                    break;
                case "Drick_Color (Instance)":
                    myRenderer.materials[i].SetColor("Color_F24BD3BC", brickColor);
                    break;
                default:
                    myRenderer.materials[i].SetColor("Color_F24BD3BC", Color.white);
                    break;
            }
        }
    }
}
