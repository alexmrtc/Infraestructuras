using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataPersistenceManager
{
    public static void SaveJson(Object data, string jsonPath)
    {
        string json = JsonUtility.ToJson(data);
        System.IO.File.WriteAllText(jsonPath, json);
    }

    public static T LoadJson<T>(string jsonPath)
    {
        string json = System.IO.File.ReadAllText(jsonPath);
        return JsonUtility.FromJson<T>(json);
    }

    public static void ToJson<T>(T[] array)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Players = array;
        string json = JsonUtility.ToJson(wrapper);
    }

    public static void SaveJsonArray<T>(T[] array, string jsonPath, bool prettyPrint)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Players = array;
        string json = JsonUtility.ToJson(wrapper, prettyPrint);
        System.IO.File.WriteAllText(jsonPath, json);
    }

    [System.Serializable]
    private class Wrapper<T>
    {
        public T[] Players;
    }
    
}
