using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxtFileManager : AbstractFileManager    //quitar el throw e implementralos. save recibe la ruta, crear el archivo. crear flujo escritor y subir algo
{
    public override List<string> Load(string filename)
    {
        throw new System.NotImplementedException();
    }

    public override void Save(string filename, List<string> content)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
