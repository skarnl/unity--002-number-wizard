using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Button higherButton;
    public Button lowerButton;
    public Text guessedNumberTextfield;

    public int minimum;
    public int maximum;

    private int minGuess;
    private int maxGuess;

    int guessedNumber;

    // Start is called before the first frame update
    void Start()
    {
        higherButton.onClick.AddListener(higherHandler);
        lowerButton.onClick.AddListener(lowerHandler);

        minGuess = minimum;
        maxGuess = maximum;

        updateTextfield();
    }

    private void higherHandler() {
        minGuess = guessedNumber + 1;

        updateTextfield();
    }

    private void lowerHandler() {
        maxGuess = guessedNumber - 1;

        updateTextfield();
    }

    private void updateTextfield() {
        guessedNumber = UnityEngine.Random.Range(maxGuess, minGuess);
        guessedNumberTextfield.text = guessedNumber.ToString();
    }
}
