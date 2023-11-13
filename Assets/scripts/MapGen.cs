using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MapGen : MonoBehaviour
{

    public GameObject roca, cubo;

    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists("mapa.txt"))
        {
            StreamReader reader = new StreamReader("mapa.txt");


            string line = "";

            int row = 0;

            while((line = reader.ReadLine()) != null) //esto lee linea por linea hasta q termina el archivo
            {
                for(int col = 0; col < line.Length; col++)
                {
                    if (line[col] == 'x')
                    {
                        Instantiate(roca, new Vector3(col, -row, 0), Quaternion.identity);
                    }
                    else if (line[col] == 'c')
                    {
                        Instantiate(cubo, new Vector3(col, -row, 0), Quaternion.identity);
                    }
                }
                row++;
            }
            reader.Close();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
