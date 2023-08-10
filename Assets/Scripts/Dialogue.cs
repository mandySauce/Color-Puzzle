using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Text text;
    public Text characterNameBox;
    public Text continueText; // Reference to the UI Text element for instructions
    public string characterName;
    [TextArea(3,4)]
    public string[] dialogueLines;
    public float textSpeed;
    private int index;
    private bool lineTypingComplete = false;

    void Start()
    {
        text.text = string.Empty;
        continueText.gameObject.SetActive(false); // Initially hide the instruction
        StartDialogue();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (lineTypingComplete)
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                text.text = dialogueLines[index];
                lineTypingComplete = true;
                continueText.gameObject.SetActive(true); // Show instruction when line is fully typed
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        lineTypingComplete = false;
        characterNameBox.text = characterName;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in dialogueLines[index].ToCharArray())
        {
            text.text += c;
            yield return new WaitForSeconds(textSpeed);
        }

        lineTypingComplete = true;
        continueText.gameObject.SetActive(true); // Show instruction when line is fully typed
    }

    void NextLine()
    {
        continueText.gameObject.SetActive(false); // Hide instruction when starting new line
        if (index < dialogueLines.Length - 1)
        {
            index++;
            text.text = string.Empty;
            lineTypingComplete = false;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}