using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static float m_gameSpeed = 1;
    public static float GameSpeed { get { return m_gameSpeed; } }

    private void Start()
    {
        Time.timeScale = m_gameSpeed;
    }

    public static void PauseGameSpeed()
    {
        m_gameSpeed = 0;
        Time.timeScale = m_gameSpeed;
    }

    
}
