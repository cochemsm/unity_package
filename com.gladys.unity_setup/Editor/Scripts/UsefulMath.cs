using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsefulMath : MonoBehaviour {
    public static Vector2 ClosestObject(Vector2 mainPoint, Vector2[] points) {
        Vector2 temp = Vector2.zero;
        float tempF = float.PositiveInfinity;
        foreach (var point in points) {
            if (Vector2.Distance(mainPoint, point) < tempF) {
                temp = point;
                tempF = Vector2.Distance(mainPoint, point);
            }
        }
        return temp;
    }

    public static Vector3 ClosestObject(Vector3 mainPoint, Vector3[] points) {
        Vector3 temp = Vector3.zero;
        float tempF = float.PositiveInfinity;
        foreach (var point in points) {
            if (Vector3.Distance(mainPoint, point) < tempF) {
                temp = point;
                tempF = Vector3.Distance(mainPoint, point);
            }
        }
        return temp;
    }

    public static GameObject ClosestObject(Transform mainPoint, GameObject[] objects) {
        GameObject temp = null;
        float tempF = float.PositiveInfinity;
        foreach (var obj in objects) {
            if (Vector3.Distance(mainPoint.position, obj.transform.position) < tempF) {
                temp = obj;
                tempF = Vector3.Distance(mainPoint.position, obj.transform.position);
            }
        }
        return temp;
    }

    public static GameObject ClosestObject(GameObject mainObject, GameObject[] objects) {
        GameObject temp = null;
        float tempF = float.PositiveInfinity;
        foreach (var obj in objects) {
            if (Vector3.Distance(mainObject.transform.position, obj.transform.position) < tempF) {
                temp = obj;
                tempF = Vector3.Distance(mainObject.transform.position, obj.transform.position);
            }
        }
        return temp;
    }
}