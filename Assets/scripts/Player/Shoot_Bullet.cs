using UnityEngine;
using System.Collections;

public class Shoot_Bullet : MonoBehaviour {
    public static Shoot_Bullet PlayerShootBullet = null;

    public GameObject Bullet = null;
    private GameObject Player = null;
    private Vector2 Player_Position;
    private const float originalFirerate = 0.7f;

    public float Firerate = 0.7f;
    private float NextFire = 1.5f;
    private float Pocaki = 2f;

    // Use this for initialization
    void Start() {
        PlayerShootBullet = this;
        Player = gameObject;
        Player_Position = Player.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate() {
        Player_Position = Player.transform.position;
        Vector2 Bullet_Position = new Vector2(Player_Position.x, Player_Position.y);

        if (Time.time >= NextFire && Time.time >= Pocaki) {
            Instantiate(Bullet, Bullet_Position, new Quaternion(0, 0, 0, 0));
            NextFire = Time.time + Firerate;
        }
    }
    /// <summary>
    /// buffi
    /// </summary>
    public void giveBuffPlayer(Buff buff)       //bom izboljsal, za zdaj se sploh ne splaca s classi in buffi se lohk stackajo :/
    {
        int[] buffAbility = buff.readBuff();

        StartCoroutine(applyBuff(buffAbility, buff.getBuffDuration()));
    }
    private IEnumerator applyBuff(int[] buffAbility, int buffDuration)
    {
        switch (buffAbility[0])
        {
            case 1:
                Firerate /= buffAbility[1];
                break;
            default:
                Debug.Log("Buff not implemented, buff nu: " + buffAbility[0]);
                break;
        }
        yield return new WaitForSeconds(buffDuration);
        Firerate = originalFirerate;
    }
}
