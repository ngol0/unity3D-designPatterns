using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillData : IAction
{
    public GameObject user;
    public IEnumerable<GameObject> targets;
    public Vector3 clickPoint;
    private bool isCanceled = false;
    public bool IsCanceled => isCanceled;

    public SkillData(GameObject user)
    {
        this.user = user;
    }

    public void Cancel()
    {
        isCanceled = true;
    }

    public void StartingCoroutine(IEnumerator coroutineToStart)
    {
        user.GetComponent<MonoBehaviour>().StartCoroutine(coroutineToStart);
    }
}
