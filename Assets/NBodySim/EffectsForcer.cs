

using System.Threading;
using UnityEngine;
public class EffectsForcer : MonoBehaviour
{
    public int BreakTime;
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Thread.Sleep(BreakTime);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // save any game data here
#if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
            UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
        }
    }
}