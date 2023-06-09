using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referência ao componente TextMeshProUGUI
    private int score = 0; // Pontuação inicial

    // Chamado quando um objeto com a tag Enemy ou Enemy2 é destruído
    public void EnemyDestroyed()
    {
        score += 10; // Adiciona 10 ao score
        UpdateScoreText(); // Atualiza o texto da pontuação
    }

    // Atualiza o texto da pontuação
    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }
}
