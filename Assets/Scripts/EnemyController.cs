using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5f;
    public float distance = 10f;
    public bool moveToLeft = false;

    private Vector3 startPosition;
    private float direction = 1f;
    private float currentDistance = 0f;

    private void Start()
    {
        startPosition = transform.position;

        // Inverte a direção inicial se moveToLeft for verdadeiro
        if (moveToLeft)
        {
            direction *= -1f;
        }
    }

    private void Update()
    {
        // Calcula o deslocamento para este frame
        float displacement = speed * Time.deltaTime * direction;

        // Atualiza a posição do objeto
        transform.position += new Vector3(displacement, 0f, 0f);

        // Atualiza a distância percorrida
        currentDistance += Mathf.Abs(displacement);

        // Verifica se a distância máxima foi atingida
        if (currentDistance >= distance)
        {
            // Inverte a direção
            direction *= -1f;
            currentDistance = 0f;

            // Rotaciona o objeto em 180°
            transform.Rotate(Vector3.up, 180f);
        }
    }
}
