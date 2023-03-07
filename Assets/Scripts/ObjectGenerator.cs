using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(BoxCollider))]
public class ObjectGenerator : MonoBehaviour
{
    public GameObject prefabObj;
    protected BoxCollider BoxCollider;

    public delegate void GenerateHandler(GameObject gameObject);
    public event GenerateHandler OnGeneratedNewObj;


    public Vector3 GetRandomSpawnPos()
    {
        Vector3 point = new Vector3(
            Random.Range(BoxCollider.bounds.min.x, BoxCollider.bounds.max.x),
            2f,
            Random.Range(BoxCollider.bounds.min.z, BoxCollider.bounds.max.z)
        );
        return point;
    }

    private void Awake()
    {
        BoxCollider = GetComponent<BoxCollider>();
    }
    private void GenerateObj()
    {
        foreach(SceneObj sceneObj in  GetComponentsInChildren<SceneObj>())
        {
            Destroy(sceneObj.gameObject);
        }

        int max = Random.Range(1, 8);

        for (int i = 0; i < max ; i++)
        {
            GameObject gameObject = Instantiate(prefabObj, this.transform);
            gameObject.transform.position = GetRandomSpawnPos();
            gameObject.name = $"Obj {i}";

            OnGeneratedNewObj?.Invoke(gameObject);
        }

    }    
}
