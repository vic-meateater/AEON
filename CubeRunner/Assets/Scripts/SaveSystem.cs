using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CubeRunner
{
    public static class SaveSystem
    {
        public static void SaveScore()
        {
            BinaryFormatter _formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/savedata/scores.data";
            FileStream stream = new FileStream(path, FileMode.Append);
            
            //TODO: save score here
            
            stream.Close();
        }
    }
}