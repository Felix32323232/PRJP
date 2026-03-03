using UnityEngine;
using UnityEngine.Rendering;

public class ParticleController : MonoBehaviour
{
    [SerializeField] private int numPar;
    [SerializeField] private float GparSpeed;
    [SerializeField] private float Gangle;
    [SerializeField] private float Gtime;
    [SerializeField] private float Ggravedad;
    [SerializeField] public GameObject Particle;
    [SerializeField] private float spawnInterval = 0.1f; 
    private float spawnTimer = 0f;

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            spawnTimer = 0f;
            CreateParticle();
        }
    }

    void CreateParticle()
    {
        GameObject par = Instantiate(Particle, transform.position, Quaternion.identity);
        Particle parScript = par.GetComponent<Particle>();
        parScript.velIn = GparSpeed * Random.Range(1, 4);
        parScript.angIn = Gangle * Random.Range(20, 60);
        parScript.angInZ = Random.Range(0, 361);
        parScript.tiempoMax = Gtime;
        parScript.gravedad = Ggravedad * Random.Range(1, 3);
    }
}
