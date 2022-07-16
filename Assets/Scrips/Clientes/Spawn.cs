using UnityEngine;

public class Spawn : MonoBehaviour
{
    private float time;

    public float spawnTimer;

    public GameObject client;

    private float test;

    static public int clientes;

    static public float dmg;

    public float dmgReciver;

    static public bool[] pos;

    // Start is called before the first frame update
    void Start()
    {
        clientes = 0;
        spawnTimer = spawnTimer - (VariableManager.dayCount / 10 ) - (VariableManager.fame / 500);
        if (spawnTimer < 0.5f)
        {
            spawnTimer = 0.5f;
        }

        dmgReciver = dmgReciver + (VariableManager.dayCount / 50) + (VariableManager.fame / 1000);
        dmg = dmgReciver;

        pos = new bool[6];
        pos[0] = false;
        pos[1] = false;
        pos[2] = false;
        pos[3] = false;
        pos[4] = false;
        pos[5] = false;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (clientes <= 0)
        {
            pos[0] = false;
            pos[1] = false;
            pos[2] = false;
            pos[3] = false;
            pos[4] = false;
            pos[5] = false;
        }

        if (time > Random.Range(spawnTimer, spawnTimer + 1f))
        {
            test = (Random.Range(0, 6));
                if (!(clientes >= 7))
            {
                switch (test)
                {
                    case 5:
                        if (pos[5] == false) 
                        {
                            //Wanted.ChangeSprite(5);
                            var pos1 = new Vector3(Random.Range(49f, 51.5f), 7.48f, 0);
                            Instantiate(client, pos1, Quaternion.identity);
                            clientes++;
                            pos[5] = true;
                        }
                        break;
                    case 4:
                        if (pos[4] == false)
                        {
                            //Wanted.ChangeSprite(4);
                            var pos2 = new Vector3(Random.Range(30f, 31f), 7.48f, 0);
                            Instantiate(client, pos2, Quaternion.identity);
                            clientes++;
                            pos[4] = true;
                        }
                        break;
                    case 3:
                        if (pos[3] == false)
                        {
                            //Wanted.ChangeSprite(3);
                            var pos3 = new Vector3(Random.Range(9f, 11.5f), 7.48f, 0);
                            Instantiate(client, pos3, Quaternion.identity);
                            clientes++;
                            pos[3] = true;
                        }
                        break;
                    case 2:
                        if (pos[2] == false)
                        {
                            //Wanted.ChangeSprite(2);
                            var pos4 = new Vector3(Random.Range(-10.75f, -8.75f), 7.48f, 0);
                            Instantiate(client, pos4, Quaternion.identity);
                            clientes++;
                            pos[2] = true;
                        }
                        break;
                    case 1:
                        if (pos[1] == false)
                        {
                            //Wanted.ChangeSprite(1);
                            var pos5 = new Vector3(Random.Range(-30.7f, -28.5f), 7.48f, 0);
                            Instantiate(client, pos5, Quaternion.identity);
                            clientes++;
                            pos[1] = true;
                        }
                        break;
                    case 0:
                        if (pos[0] == false)
                        {
                            //Wanted.ChangeSprite(0);
                            var pos6 = new Vector3(Random.Range(-51f, -47.5f), 7.48f, 0);
                            Instantiate(client, pos6, Quaternion.identity);
                            clientes++;
                            pos[0] = true;
                        }
                        break;

                    default:
                        print("Rare error kinda sussy");
                        break;
                }
            }
            time = 0;
        }
    }
}
