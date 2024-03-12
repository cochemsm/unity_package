using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsefulFunctions : MonoBehaviour {
    // Function from Code Monkey Tutorial
    public static Vector3 FindCursor2D() {
        Camera camera = Camera.current;
        Vector3 mouseWorldPosition = camera.WorldToScreenPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
    }

    // Function from Code Monkey Tutorial
    public static Vector3 FindCursor2D(Camera camera) {
        Vector3 mouseWorldPosition = camera.WorldToScreenPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
    }

    // Function from Code Monkey Tutorial
    public static Vector3 FindCursor3D() {
        Camera camera = Camera.current;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit)) {
            return raycastHit.point;
        }
        return Vector3.zero;
    }

    // Function from Code Monkey Tutorial
    public static Vector3 FindCursor3D(Camera camera) {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit)) {
            return raycastHit.point;
        }
        return Vector3.zero;
    }

    // Function from Code Monkey Tutorial
    public static Vector3 FindCursor3D(LayerMask layerMask) {
        Camera camera = Camera.current;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, layerMask)) {
            return raycastHit.point;
        }
        return Vector3.zero;
    }

    // Function from Code Monkey Tutorial
    public static Vector3 FindCursor3D(LayerMask layerMask, Camera camera) {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, layerMask)) {
            return raycastHit.point;
        }
        return Vector3.zero;
    }

    // Function from Code Monkey Tutorial
    public static Vector3 FindCursor3D(LayerMask layerMask, float maxDistance) {
        Camera camera = Camera.current;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, maxDistance, layerMask)) {
            return raycastHit.point;
        }
        return Vector3.zero;
    }

    // Function from Code Monkey Tutorial
    public static Vector3 FindCursor3D(LayerMask layerMask, float maxDistance, Camera camera) {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, maxDistance, layerMask)) {
            return raycastHit.point;
        }
        return Vector3.zero;
    }
}