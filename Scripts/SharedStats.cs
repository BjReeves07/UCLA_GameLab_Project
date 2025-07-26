using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SharedStats
{
    public const int kSceneIs_TitleScene = 0;
    public const int kSceneIs_ActualGameScene = 1;
    public const int kSceneIs_HighScoreScene = 2;

    public static int highScore = 0;
    public static int enemyID = 0;

    public static void sampleFunction()
    {
        //this is a sample method you can call from any other script
    }

}