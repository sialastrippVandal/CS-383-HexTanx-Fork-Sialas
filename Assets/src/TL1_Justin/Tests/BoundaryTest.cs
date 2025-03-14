using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BoundaryTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void BoundaryTestSimplePasses()
    {
        // Use the Assert class to test conditions
        SceneManager.LoadScene("MainMenu");
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator BoundaryTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        var mainMenu = GameObject.Find("MainMenuScreen");
        // mainMenu.PlayButton();
        yield return null;
    }
}
