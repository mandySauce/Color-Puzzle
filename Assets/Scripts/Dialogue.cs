using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public GameObject dialogueBox;
    public Text text;
    public Text characterNameBox;
    public Text continueText;
    public string characterName;
    [TextArea(3,4)]
    public string[] dialogueLines;
    public float textSpeed;
    private int index;
    private bool lineTypingComplete = true; // Set it to true initially
    public bool playDialogue = false;

    void Start()
    {
        continueText.gameObject.SetActive(false);
        if (playDialogue)
        {
            StartDialogue();
        }
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
                continueText.gameObject.SetActive(true);
            }
        }
    }

    void StartDialogue()
    {
        text.text = string.Empty;
        dialogueBox.SetActive(true);
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
        continueText.gameObject.SetActive(true);
    }

    void NextLine()
    {
        continueText.gameObject.SetActive(false);
        if (index < dialogueLines.Length - 1)
        {
            index++;
            text.text = string.Empty;
            lineTypingComplete = false;
            StartCoroutine(TypeLine());
        }
        else
        {
            dialogueBox.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !playDialogue) // Only start dialogue if not already playing
        {
            playDialogue = true;
            StartDialogue();
        }
    }
}
