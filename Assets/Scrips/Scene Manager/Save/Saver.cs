using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Saver
{
    public static bool canLoad;
    public static void SaveData (Loader data)
    {
        Data datos = new Data(data);

        string dataPath = Application.persistentDataPath + "/gamesave.save";

        FileStream fileStream = new FileStream(dataPath, FileMode.Create);
        BinaryFormatter binaryFormmater = new BinaryFormatter();
        binaryFormmater.Serialize(fileStream, datos);

        fileStream.Close();
    }

    public static Data LoadData()
    {
        string dataPath = Application.persistentDataPath + "/gamesave.save";
        
        if (File.Exists(dataPath))
        {
            FileStream fileStream = new FileStream(dataPath, FileMode.Open);
            BinaryFormatter binaryFormmater = new BinaryFormatter();
            Data datos = (Data)binaryFormmater.Deserialize(fileStream);

            fileStream.Close();
            canLoad = true;
            return datos;
        }
        else
        {
            canLoad = false;
            return null;
        }
    }
}
