using UnityEngine;


[CreateAssetMenu(fileName = "New Question", menuName = "Quiz Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(1, 4)]
    [SerializeField] string question = "Enter new question text here";
    [SerializeField] string[] answers = new string[5];
    [SerializeField] int correctAnswerIndex;
    public string GetQuestion()
    {
        return question;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }
    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }
}
