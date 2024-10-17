using TMPro;
using UnityEngine;

public class GuessTheNumber : MonoBehaviour
{

    public TMP_Text messageText;
    public TMP_InputField numberInput;

    private int randomNumber;

    private void Start()
    {
        ResetGame();
    }

    public void Try()
    {
        if(int.TryParse(numberInput.text, out int playerNumber))
        {
            if (playerNumber == randomNumber)
            {
                messageText.text = "Victory!";
            }
            else if (playerNumber > randomNumber)
            {
                messageText.text = "Lower";
            }
            else if (playerNumber < randomNumber)
            {
                messageText.text = "Greater";
            }
            // Si playerNumber est egal a randomNumber
            // Victoire (changer le message, reset le champ texte)
            // Sinon si, playerNumber est superieur a randomNumber
            // Annoncer "moins"
            // Sinon si playerNumber est inferieur a randomNumber
            // Annoncer ''plus''
        }
        else
        {
            messageText.text = "Enter a Valid Number";
        }

        numberInput.text = "";

    }

    public void ResetGame()
    {
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("Generated Number: " + randomNumber);
        messageText.text = "Guess the Number";
    }



}


