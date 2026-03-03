using UnityEngine;

public class Particle : MonoBehaviour
{

    public float velIn;
    public float angIn;
    public float angInZ;
    public float tiempoMax;
    public float tiempo;
    public float gravedad;


    void Start()
    {
        
    }

    void Update()
    {
        tiempo += Time.deltaTime;
        float angleRad = angIn * Mathf.Deg2Rad;
        float angleZRad = angInZ * Mathf.Deg2Rad;
        float x = velIn * Mathf.Cos(angleRad) * tiempo;
        float y = velIn * Mathf.Sin(angleRad) * tiempo - 0.5f * gravedad * tiempo * tiempo;
        float z = velIn * Mathf.Cos(angleZRad) * tiempo;
        transform.position = new Vector3(x, y, z);

        if (tiempo > tiempoMax)
        {
            Destroy(gameObject);
        }
    }
}
