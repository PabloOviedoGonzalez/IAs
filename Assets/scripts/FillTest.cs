using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FillTest : MonoBehaviour
{
    public string fileName;

    //private Vector3 StringToV3(string stringvector)
    //{
    //    x = x.Substring(1, x.Length - 2);
    //    string[] xposDivided = x.Split(',');
    //    for (int i = 0; i < xposDivided.Length; i++)
    //    {
    //        xposDivided[i] = xposDivided[i].Replace('.', ',');
    //    }

    //    Vector3 nPosition = new Vector3(float.Parse(xposDivided[0]), float.Parse(xposDivided[1]), float.Parse(xposDivided[2]));
    //    return nPosition;

    //}

    // cargar datos
    private void Awake()
    {
        if (File.Exists(Application.persistentDataPath + "\\" + fileName))
        {
            StreamReader sr = new StreamReader(Application.persistentDataPath + "\\" + fileName);

            string x = sr.ReadLine();
            string Sc = sr.ReadLine();
           // string y = sr.ReadLine();
           // string z = sr.ReadLine();

            sr.Close();


            x = x.Substring(1, x.Length - 2);
            Sc = Sc.Substring(1, x.Length - 2);

            string[] xposDivided = x.Split(',');
            string[] ScDivided = Sc.Split(',');

            for(int i = 0; i < xposDivided.Length; i++)
            {
                xposDivided[i] = xposDivided[i].Replace('.', ',');
            } 
            for(int i = 0; i < ScDivided.Length; i++)
            {
                ScDivided[i] = ScDivided[i].Replace('.', ',');
            }


            //Vector3 nPosition = new Vector3(float.Parse(x), float.Parse(y), float.Parse(z));
            // transform.position = nPosition;

            Vector3 nPosition = new Vector3(float.Parse(xposDivided[0]), float.Parse(xposDivided[1]), float.Parse(xposDivided[2]));
            transform.position = nPosition;



            


        }
      
    }

    // Update is called once per frame
    void Update()  //guardar partida
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            FileStream fs = File.Create(Application.persistentDataPath + "\\" + fileName);  //crea el flujo si no esta creado

            StreamWriter streamWriter = new StreamWriter(fs); //nos ayuda a escribir en el flujo de antes

            streamWriter.WriteLine(transform.position.ToString());  //hemos escrito
            streamWriter.WriteLine(transform.localScale.ToString());  //hemos escrito
            //streamWriter.WriteLine(transform.position.y.ToString());
           // streamWriter.WriteLine(transform.position.z.ToString());
           

            streamWriter.Close();
            fs.Close();
        }
    }
}
