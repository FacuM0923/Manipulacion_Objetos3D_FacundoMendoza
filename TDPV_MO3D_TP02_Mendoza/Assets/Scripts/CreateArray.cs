using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject bloquePrefab;
    public int N = 3;
    public int M = 4;

    void Start(){
        CrearMuro(N, M);
    }

    void CrearMuro(int N, int M){
        
        Renderer render = bloquePrefab.GetComponentInChildren<Renderer>();
        Vector3 bloqueSize = render.bounds.size; 

        for(int i = 0; i < N; i++){

            for(int j = 0; j < M; j++){

                Vector3 position = new Vector3(i * bloqueSize.x, j * bloqueSize.y, 0);
                Instantiate(bloquePrefab, position, Quaternion.identity);

            }

        }

    }

}
