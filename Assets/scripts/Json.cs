using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Json : MonoBehaviour
{

    public string jsonFilName;

    [System.Serializable]  //quiere decir q esto se puede volcar en un archivo y del archivo a la clase
    struct PlayerInfo    //es una miniclase
    {
       public Vector3 position;
    }
    // Start is called before the first frame update
    void Start()
    {
        Load();
    }

    void Load()
    {
        if (File.Exists(Application.persistentDataPath + "\\" + jsonFilName))
        {
            StreamReader reader = new StreamReader(Application.persistentDataPath + "\\" + jsonFilName);
            string entireFile = reader.ReadToEnd();
            PlayerInfo info = JsonUtility.FromJson<PlayerInfo>(entireFile);
            transform.position = info.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            PlayerInfo info = new PlayerInfo();
            info.position = transform.position;
            StreamWriter writer = new StreamWriter(Application.persistentDataPath + "\\" + jsonFilName);
            string jsonInfo = JsonUtility.ToJson(info); //duvuelve un string en forma que json lo admite
            writer.Write(jsonInfo);
            writer.Close();

        }
    }
}
