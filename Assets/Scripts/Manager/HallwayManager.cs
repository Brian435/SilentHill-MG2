using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayManager : MonoBehaviour
{
  // Variables publicas
   public GameObject [] hallway;

  //Variables privadas 
    private int hallwayIndex = 0;

    //Funcion para activar un nuevo pasillo 
    public void LoadHallway()
    {
      //Aumentamos el indes en 1
      hallwayIndex++;

        //Activamos el siguiente pasillo 
        if (hallwayIndex < (hallway.Length - 1))
        {
            hallway[hallwayIndex + 1].gameObject.SetActive(true);
        }
    }

    //Funcion para desactivar el pasillo anterior
    public void UnloadHallway()
    {
        // Llamamos a la corrutina
        StartCoroutine(UnloadHallwayCoroution(1.5f));

    }

        //Corrutin para desactivar el pasillo
    IEnumerator UnloadHallwayCoroution(float _time)
    {
        //Esperamos unos segundos 
        yield return new WaitForSeconds(_time);

        //Desactivamos el pasillo anterior 
        if(hallwayIndex < 0)
        {
            hallway[hallwayIndex - 1].gameObject.SetActive(false);
        }
    }
}
