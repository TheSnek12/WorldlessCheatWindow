using System.Numerics;
using Noname;
using UnityEngine;
using UniverseLib.Input;

namespace WorldlessCheatWindow;
public class KeyManager
{
    static internal void Update()
    {
        if (UniverseLib.Input.InputManager.GetKeyDown(KeyCode.F6))
        {
            UIManager.ShowUI = !UIManager.ShowUI;
        }
        if (UniverseLib.Input.InputManager.GetKey(KeyCode.W) && AbilityManager.noclipping)
        {
            GameObject.Find("BaseNavigation").transform.position += UnityEngine.Vector3.up;
        }
        if (UniverseLib.Input.InputManager.GetKey(KeyCode.A) && AbilityManager.noclipping)
        {
            GameObject.Find("BaseNavigation").transform.position += UnityEngine.Vector3.left;
        }
        if (UniverseLib.Input.InputManager.GetKey(KeyCode.S) && AbilityManager.noclipping)
        {
            GameObject.Find("BaseNavigation").transform.position += UnityEngine.Vector3.down;
        }
        if (UniverseLib.Input.InputManager.GetKey(KeyCode.D) && AbilityManager.noclipping)
        {
            GameObject.Find("BaseNavigation").transform.position += UnityEngine.Vector3.right;
        }
    }
}